using CleanArchitecture.ISP.DeviceSync.Domain.Brands.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.DeviceSync.BiometricsService.Infrastructure.PointClockGateways;
internal static class PointClockGatewayFactory
{
    internal static IControlIDGateway CreateControlID(PointClock pointClock)
    {
        return pointClock.Brand switch
        {
            Brand.ControlID => new ControlIDGateway(pointClock),
            _ => throw new NotSupportedException($"Unsupported point clock model: '{pointClock.Brand}'")
        };
    }
}
