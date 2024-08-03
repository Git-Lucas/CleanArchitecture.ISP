using CleanArchitecture.ISP.Domain.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Actions.Biometrics.OperationResult;
public record ShareBiometricsSuccess(string PointClockIp, int NumberOfSharedBiometrics) : Result(true)
{
}
