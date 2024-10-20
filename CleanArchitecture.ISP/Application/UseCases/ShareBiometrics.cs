﻿using CleanArchitecture.ISP.Application.OperationResult;
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

public record ShareBiometricsRequest(PointClock[] PointClocks)
{
}

public record ShareBiometricsSuccess(string PointClockIp, int NumberOfSharedBiometrics) : Result(true)
{
}

public record ShareBiometricsPointClockNotSupported : Result
{
    public string MessageError { get; }

    public ShareBiometricsPointClockNotSupported(string messageError)
        : base(false)
    {
        MessageError = "The functionality was not executed. Reason: " + messageError;
    }
}
