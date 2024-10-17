using CleanArchitecture.ISP.Application.OperationResult;
using CleanArchitecture.ISP.Application.UseCases;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.Infrastructure.PointClockGateways;
public class HenryGateway(PointClock pointClock) : IPointClockGenericGateway
{
    private readonly PointClock _pointClock = pointClock;

    public Result SetDateTime()
    {
        Console.WriteLine($"{nameof(HenryGateway)}: Sending request to https://{_pointClock.Ip}:{_pointClock.Port}");

        return new SetDateTimeSuccess(_pointClock.Ip);
    }
}
