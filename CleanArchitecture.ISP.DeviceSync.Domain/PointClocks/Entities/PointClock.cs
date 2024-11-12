using CleanArchitecture.ISP.DeviceSync.Domain.Brands.Entities;

namespace CleanArchitecture.ISP.DeviceSync.Domain.PointClocks.Entities;
public class PointClock(string ip, int port, Brand brand)
{
    public string Ip { get; private set; } = ip;
    public int Port { get; private set; } = port;
    public Brand Brand { get; private set; } = brand;
}
