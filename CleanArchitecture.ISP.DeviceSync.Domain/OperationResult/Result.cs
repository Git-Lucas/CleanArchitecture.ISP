using System.Text.Json.Serialization;

namespace CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;

[JsonDerivedType(typeof(SetDateTimeSuccess), nameof(SetDateTimeSuccess))]
[JsonDerivedType(typeof(ShareBiometricsSuccess), nameof(ShareBiometricsSuccess))]
[JsonDerivedType(typeof(ShareBiometricsPointClockNotSupported), nameof(ShareBiometricsPointClockNotSupported))]
public record Result(bool IsSuccess)
{
}
