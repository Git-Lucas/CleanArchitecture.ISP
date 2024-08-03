using CleanArchitecture.ISP.Domain.PointClocks.Entities;

namespace CleanArchitecture.ISP.Domain.PointClocks.Actions.PointClockDateTime.DTOs;
public record SetDateTimeRequest(PointClock[] PointClocks)
{
}
