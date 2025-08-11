namespace HRIS.Domain.Enums
{
    public enum PayrollStatus
    {
        Draft = 0,
        PendingApproval = 1,
        Approved = 2,
        Processed = 3,
        Paid = 4,
        Cancelled = 5
    }
}