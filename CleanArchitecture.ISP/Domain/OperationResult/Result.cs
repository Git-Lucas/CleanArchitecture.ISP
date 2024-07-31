using System.Text.Json.Serialization;

namespace CleanArchitecture.ISP.Domain.OperationResult;

[JsonDerivedType(typeof(SetDateTimeSuccess), nameof(SetDateTimeSuccess))]
public record Result<T>(bool Success) where T : class
{
}
