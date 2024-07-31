using CleanArchitecture.ISP.Application.UseCases;
using CleanArchitecture.ISP.Domain.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;

namespace CleanArchitecture.ISP.Infrastructure.PointClockGateways;
public class ControlIDGateway(PointClock pointClock) : IPointClockGenericGateway
{
    private readonly PointClock _pointClock = pointClock;

    public Result<SetDateTime> SetDateTime()
    {
        Console.WriteLine($"{nameof(ControlIDGateway)}: Sending request to https://{_pointClock.Ip}:{_pointClock.Port}");

        return new SetDateTimeSuccess(_pointClock.Ip);
    }
}
