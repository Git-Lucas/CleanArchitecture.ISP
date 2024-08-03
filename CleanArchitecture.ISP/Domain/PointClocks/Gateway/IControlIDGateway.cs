using CleanArchitecture.ISP.Domain.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Gateway;
public interface IControlIDGateway
{
    Result ShareBiometrics();
}
