using CleanArchitecture.ISP.Application.UseCases;

namespace CleanArchitecture.ISP.Domain.OperationResult;
public record SetDateTimeSuccess() : Result<SetDateTime>(true)
{
    public DateTime SettedDateTime => DateTime.UtcNow;
}
