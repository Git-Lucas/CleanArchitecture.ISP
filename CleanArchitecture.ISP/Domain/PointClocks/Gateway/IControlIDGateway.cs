using CleanArchitecture.ISP.Application.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Gateway;
public interface IControlIDGateway
{
    Result ShareBiometrics();
}
