using ContractsTestWork.DataLayer.Repositories.Interfaces;
using ContractsTestWork.Domain.Services.Interfaces;
using ContractsTestWork.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace ContractsTestWork.Domain.Services;

public class ContractsImportService : IContractImportService
{
    private readonly IContractImportRepo _contractsImportRepo;

    public ContractsImportService(IContractImportRepo contractsImportRepo)
    {
        _contractsImportRepo = contractsImportRepo;
    }

    public async Task<IActionResult> ImportContracts(IFormFile? file)
    {
        if (file == null || file.Length == 0)
        {
            return new BadRequestResult();
        }

        await using var stream = file.OpenReadStream();
        using var xlPackage = new ExcelPackage(stream);

        var contractWorksheet = xlPackage.Workbook.Worksheets.First();
        var stagesWorksheet = xlPackage.Workbook.Worksheets[1];

        await AddContracts(contractWorksheet);
        await AddStages(stagesWorksheet);

        return new OkResult();
    }

    private async Task AddContracts(ExcelWorksheet contractWorksheet)
    {
        for (var row = 2; row <= contractWorksheet.Dimension.End.Row; row++)
        {
            // читаем ячейки 
            var contractCode = contractWorksheet.Cells[row, 1].Value?.ToString()?.Trim();
            var contractName = contractWorksheet.Cells[row, 2].Value?.ToString()?.Trim();
            var customerName = contractWorksheet.Cells[row, 3].Value?.ToString()?.Trim();

            // TODO: валидация данных

            var contract = new Contract
            {
                Code = contractCode,
                Name = contractName,
                Customer = customerName
            };
            await _contractsImportRepo.Add(contract);
        }
    }

    private async Task AddStages(ExcelWorksheet stagesWorksheet)
    {
        for (var row = 2; row <= stagesWorksheet.Dimension.End.Row; row++)
        {
            // читаем ячейки 
            var stageName = stagesWorksheet.Cells[row, 1].Value?.ToString()?.Trim();
            var startDate = Convert.ToDateTime(stagesWorksheet.Cells[row, 2].Value?.ToString()?.Trim());
            var endDate = Convert.ToDateTime(stagesWorksheet.Cells[row, 3].Value?.ToString()?.Trim());
            var contractId = stagesWorksheet.Cells[row, 4].Value?.ToString()?.Trim();

            // TODO: валидация данных

            var stage = new ContractStage()
            {
                Name = stageName,
                StartDate = startDate,
                EndDate = endDate,
                ContractId = Convert.ToInt32(contractId)
            };
            await _contractsImportRepo.Add(stage);
        }
    }
}