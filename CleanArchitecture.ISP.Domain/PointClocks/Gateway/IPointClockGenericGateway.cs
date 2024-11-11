using CleanArchitecture.ISP.Domain.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Gateway;
public interface IPointClockGenericGateway
{
    Result SetDateTime();
}
