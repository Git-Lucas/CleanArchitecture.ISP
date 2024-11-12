namespace CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
public record SetDateTimeSuccess(string PointClockIp) : Result(true)
{
    public DateTime SettedDateTime => DateTime.UtcNow;
}
