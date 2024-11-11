using CleanArchitecture.ISP.Domain.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.Domain.PointClocks.Gateway;
using CleanArchitecture.ISP.Infrastructure.PointClockGateways;

namespace CleanArchitecture.ISP.Application.UseCases;
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
