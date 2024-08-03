using CleanArchitecture.ISP.Domain.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Actions.Biometrics.OperationResult;
public record ShareBiometricsPointClockNotSupported : Result
{
    public string MessageError { get; }

    public ShareBiometricsPointClockNotSupported(string messageError)
        : base(false)
    {
        MessageError = "The functionality was not executed. Reason: " + messageError;
    }
}
