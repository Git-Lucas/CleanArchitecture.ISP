using CleanArchitecture.ISP.DeviceSync.Domain.Brands.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;
using CleanArchitecture.ISP.Infrastructure.PointClockGateways;

namespace CleanArchitecture.ISP.DeviceSync.Infrastructure.PointClockGateways;
public static class PointClockGatewayFactory
{
    public static IPointClockGenericGateway CreateGeneric(PointClock pointClock)
    {
        return pointClock.Brand switch
        {
            Brand.ControlID => new ControlIDGateway(pointClock),
            Brand.Henry => new HenryGateway(pointClock),
            _ => throw new NotSupportedException($"Unsupported point clock model: '{pointClock.Brand}'")
        };
    }

    public static IControlIDGateway CreateControlID(PointClock pointClock)
    {
        return pointClock.Brand switch
        {
            Brand.ControlID => new ControlIDGateway(pointClock),
            _ => throw new NotSupportedException($"Unsupported point clock model: '{pointClock.Brand}'")
        };
    }
}
