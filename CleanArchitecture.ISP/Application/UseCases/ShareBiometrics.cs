using CleanArchitecture.ISP.Domain.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks.Actions.Biometrics.DTOs;
using CleanArchitecture.ISP.Domain.PointClocks.Actions.Biometrics.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;
using CleanArchitecture.ISP.Domain.PointClocks.Gateway;

namespace CleanArchitecture.ISP.Application.UseCases;
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
