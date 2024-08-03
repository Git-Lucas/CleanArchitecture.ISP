using CleanArchitecture.ISP.Domain.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Actions.PointClockDateTime.OperationResult;
public record SetDateTimeSuccess(string PointClockIp) : Result(true)
{
    public DateTime SettedDateTime => DateTime.UtcNow;
}
