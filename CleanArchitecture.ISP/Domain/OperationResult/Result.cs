using CleanArchitecture.ISP.Domain.PointClocks.Actions.Biometrics.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks.Actions.PointClockDateTime.OperationResult;
using System.Text.Json.Serialization;

namespace CleanArchitecture.ISP.Domain.OperationResult;

[JsonDerivedType(typeof(SetDateTimeSuccess), nameof(SetDateTimeSuccess))]
[JsonDerivedType(typeof(ShareBiometricsSuccess), nameof(ShareBiometricsSuccess))]
[JsonDerivedType(typeof(ShareBiometricsPointClockNotSupported), nameof(ShareBiometricsPointClockNotSupported))]
public record Result(bool IsSuccess)
{
}
