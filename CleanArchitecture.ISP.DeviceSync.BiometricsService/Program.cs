using CleanArchitecture.ISP.DeviceSync.BiometricsService;
using CleanArchitecture.ISP.DeviceSync.BiometricsService.Application.UseCases;
using CleanArchitecture.ISP.DeviceSync.Domain.Brands.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;

PointClock[] pointClocks = [
    new PointClock("192.168.254.221", 443, Brand.ControlID),
    new PointClock("192.168.254.222", 3000, Brand.Henry)];

ShareBiometrics shareBiometricsUseCase = new();

ShareBiometricsRequest shareBiometricsRequest = new(pointClocks);

IEnumerable<Result> resultShareBiometrics = shareBiometricsUseCase.Execute(shareBiometricsRequest);

Console.WriteLine(Serializer.Serialize(resultShareBiometrics));