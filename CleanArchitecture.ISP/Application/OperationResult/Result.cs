using CleanArchitecture.ISP.Application.UseCases;
using System.Text.Json.Serialization;

namespace CleanArchitecture.ISP.Application.OperationResult;

[JsonDerivedType(typeof(SetDateTimeSuccess), nameof(SetDateTimeSuccess))]
[JsonDerivedType(typeof(ShareBiometricsSuccess), nameof(ShareBiometricsSuccess))]
[JsonDerivedType(typeof(ShareBiometricsPointClockNotSupported), nameof(ShareBiometricsPointClockNotSupported))]
public record Result(bool IsSuccess)
{
}
