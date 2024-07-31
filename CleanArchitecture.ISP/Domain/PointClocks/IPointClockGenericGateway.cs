using CleanArchitecture.ISP.Application.UseCases;
using CleanArchitecture.ISP.Domain.OperationResult;

namespace CleanArchitecture.ISP.Domain.PointClocks;
public interface IPointClockGenericGateway
{
    Result<SetDateTime> SetDateTime();
}
