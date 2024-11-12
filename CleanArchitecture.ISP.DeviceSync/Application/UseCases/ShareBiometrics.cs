using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;
using CleanArchitecture.ISP.DeviceSync.Infrastructure.PointClockGateways;

namespace CleanArchitecture.ISP.DeviceSync.Application.UseCases;
public class ShareBiometrics
{
    public IEnumerable<Result> Execute(ShareBiometricsRequest request)
    {
        List<Result> actionResults = [];

        foreach (PointClock pointClock in request.PointClocks)
        {
            try
            {
                IControlIDGateway controlIDGateway = PointClockGatewayFactory.CreateControlID(pointClock);

                actionResults.Add(controlIDGateway.ShareBiometrics());
            }
            catch (NotSupportedException exception)
            {
                actionResults.Add(new ShareBiometricsPointClockNotSupported(exception.Message));
            }
        }

        return actionResults;
    }
}

public record ShareBiometricsRequest(PointClock[] PointClocks)
{
}
