using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.DeviceSync.BiometricsService.Infrastructure.PointClockGateways;
internal class ControlIDGateway(PointClock pointClock) : IControlIDGateway
{
    private readonly PointClock _pointClock = pointClock;

    public Result ShareBiometrics()
    {
        int randomNumberOfSharedBiometrics = new Random().Next(800);

        Console.WriteLine($"{nameof(ControlIDGateway)}: Sending request to https://{_pointClock.Ip}:{_pointClock.Port}");
        Console.WriteLine($"{nameof(ControlIDGateway)}: Comparing biometrics...");
        Console.WriteLine($"{nameof(ControlIDGateway)}: Sharing {randomNumberOfSharedBiometrics} biometrics...");

        return new ShareBiometricsSuccess(_pointClock.Ip, randomNumberOfSharedBiometrics);
    }
}
