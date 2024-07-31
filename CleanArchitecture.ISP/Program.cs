using CleanArchitecture.ISP;
using CleanArchitecture.ISP.Application.UseCases;
using CleanArchitecture.ISP.Domain.Brands.Entities;
using CleanArchitecture.ISP.Domain.OperationResult;
using CleanArchitecture.ISP.Domain.PointClocks.Actions.DateTime.DTOs;
using CleanArchitecture.ISP.Domain.PointClocks.Entities;

SetDateTime setDateTimeUseCase = new();

SetDateTimeRequest setDateTimeRequest = new([
    new PointClock("192.168.254.221", 443, Brand.ControlID),
    new PointClock("192.168.254.222", 3000, Brand.Henry)]);

IEnumerable<Result<SetDateTime>> resultActions = setDateTimeUseCase.Execute(setDateTimeRequest);

Console.WriteLine(Serializer.Serialize(resultActions));