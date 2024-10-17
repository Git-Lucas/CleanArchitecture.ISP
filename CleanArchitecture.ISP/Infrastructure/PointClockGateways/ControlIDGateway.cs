using CleanArchitecture.ISP.Application.OperationResult;
using CleanArchitecture.ISP.Application.UseCases;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.Infrastructure.PointClockGateways;
public class ControlIDGateway(PointClock pointClock) : IPointClockGenericGateway, IControlIDGateway
{
    private readonly PointClock _pointClock = pointClock;

    public Result SetDateTime()
    {
        Console.WriteLine($"{nameof(ControlIDGateway)}: Sending request to https://{_pointClock.Ip}:{_pointClock.Port}");

        return new SetDateTimeSuccess(_pointClock.Ip);
    }

    public Result ShareBiometrics()
    {
        int randomNumberOfSharedBiometrics = new Random().Next(800);

        Console.WriteLine($"{nameof(ControlIDGateway)}: Sending request to https://{_pointClock.Ip}:{_pointClock.Port}");
        Console.WriteLine($"{nameof(ControlIDGateway)}: Comparing biometrics...");
        Console.WriteLine($"{nameof(ControlIDGateway)}: Sharing {randomNumberOfSharedBiometrics} biometrics...");

        return new ShareBiometricsSuccess(_pointClock.Ip, randomNumberOfSharedBiometrics);
    }
}
