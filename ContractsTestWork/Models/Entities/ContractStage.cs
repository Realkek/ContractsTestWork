namespace ContractsTestWork.Models.Entities;

public class ContractStage : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int ContractId { get; set; }
    public Contract Contract { get; set; }
}