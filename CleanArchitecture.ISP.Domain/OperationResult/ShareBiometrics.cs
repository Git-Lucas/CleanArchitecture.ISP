namespace CleanArchitecture.ISP.Domain.OperationResult;
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
