using CleanArchitecture.ISP.Domain.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks;
using CleanArchitecture.ISP.Domain.PointClocks.Actions.DateTime.DTOs;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.Application.UseCases;
public class SetDateTime
{
    public IEnumerable<Result<SetDateTime>> Execute(SetDateTimeRequest request)
    {
        List<Result<SetDateTime>> resultsAction = [];

        foreach (PointClock pointClock in request.PointClocks)
        {
            IPointClockGenericGateway pointClockGenericGateway = PointClockGatewayFactory.Create(pointClock);

            resultsAction.Add(pointClockGenericGateway.SetDateTime());
        }

        return resultsAction;
    }
}
