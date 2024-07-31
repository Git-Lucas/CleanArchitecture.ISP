using CleanArchitecture.ISP.Application.UseCases;

namespace CleanArchitecture.ISP.Domain.OperationResult;
public record SetDateTimeSuccess(string PointClockIp) : Result<SetDateTime>(true)
{
    public DateTime SettedDateTime => DateTime.UtcNow;
}
