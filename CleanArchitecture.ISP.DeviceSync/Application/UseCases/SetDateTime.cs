using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;
using CleanArchitecture.ISP.DeviceSync.Infrastructure.PointClockGateways;

namespace CleanArchitecture.ISP.DeviceSync.Application.UseCases;
public class SetDateTime
{
    public IEnumerable<Result> Execute(SetDateTimeRequest request)
    {
        List<Result> resultsAction = [];

        foreach (PointClock pointClock in request.PointClocks)
        {
            IPointClockGenericGateway pointClockGenericGateway = PointClockGatewayFactory.CreateGeneric(pointClock);

            resultsAction.Add(pointClockGenericGateway.SetDateTime());
        }

        return resultsAction;
    }

}

public record SetDateTimeRequest(PointClock[] PointClocks)
{
}
