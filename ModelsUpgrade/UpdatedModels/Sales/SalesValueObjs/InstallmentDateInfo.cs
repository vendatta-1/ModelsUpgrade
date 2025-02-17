namespace ModelsUpgrade.UpdatedModels.Sales.SalesValueObjs
{
    public record InstallmentDateInfo
    (
        int? Years,
        int? Month,
        DateOnly? StartDate
    );
}
