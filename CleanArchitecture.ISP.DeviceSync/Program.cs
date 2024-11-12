using CleanArchitecture.ISP.DeviceSync;
using CleanArchitecture.ISP.DeviceSync.Application.UseCases;
using CleanArchitecture.ISP.DeviceSync.Domain.Brands.Entities;
using CleanArchitecture.ISP.DeviceSync.Domain.OperationResult;
using CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;

PointClock[] pointClocks = [
    new PointClock("192.168.254.221", 443, Brand.ControlID),
    new PointClock("192.168.254.222", 3000, Brand.Henry)];

SetDateTime setDateTimeUseCase = new();

SetDateTimeRequest setDateTimeRequest = new(pointClocks);

IEnumerable<Result> resultSetDateTime = setDateTimeUseCase.Execute(setDateTimeRequest);

Console.WriteLine(Serializer.Serialize(resultSetDateTime));

//------------------------------------------------------------------------------------------------------------------

Console.WriteLine();

ShareBiometrics shareBiometricsUseCase = new();

ShareBiometricsRequest shareBiometricsRequest = new(pointClocks);

IEnumerable<Result> resultShareBiometrics = shareBiometricsUseCase.Execute(shareBiometricsRequest);

Console.WriteLine(Serializer.Serialize(resultShareBiometrics));