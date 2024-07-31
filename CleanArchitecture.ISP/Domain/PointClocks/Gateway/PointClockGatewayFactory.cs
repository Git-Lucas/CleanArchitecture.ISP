using CleanArchitecture.ISP.Domain.Brands.Entities;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.Infrastructure.PointClockGateways;

namespace CleanArchitecture.ISP.Domain.PointClocks.Gateway;
public static class PointClockGatewayFactory
{
    public static IPointClockGenericGateway Create(PointClock pointClock)
    {
        return pointClock.Brand switch
        {
            Brand.ControlID => new ControlIDGateway(pointClock),
            Brand.Henry => new HenryGateway(pointClock),
            _ => throw new NotSupportedException($"Modelo de relógio não suportado: '{pointClock.Brand.ToString()}'")
        };
    }
}
