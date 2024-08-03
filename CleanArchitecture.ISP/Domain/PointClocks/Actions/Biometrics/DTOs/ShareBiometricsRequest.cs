using CleanArchitecture.ISP.Domain.PointClocks.Entities;

namespace CleanArchitecture.ISP.Domain.PointClocks.Actions.Biometrics.DTOs;
public record ShareBiometricsRequest(PointClock[] PointClocks)
{
}
