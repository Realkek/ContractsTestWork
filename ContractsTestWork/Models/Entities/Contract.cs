namespace ContractsTestWork.Models.Entities;

public class Contract : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Customer { get; set; }
    public List<ContractStage> Stages { get; set; } = new();
}