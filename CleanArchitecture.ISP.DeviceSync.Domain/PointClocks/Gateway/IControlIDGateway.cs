using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;

namespace CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Gateway;
public interface IControlIDGateway
{
    Result ShareBiometrics();
}
