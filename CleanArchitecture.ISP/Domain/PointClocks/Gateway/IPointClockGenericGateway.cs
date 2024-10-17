using CleanArchitecture.ISP.Application.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks.Gateway;
public interface IPointClockGenericGateway
{
    Result SetDateTime();
}
