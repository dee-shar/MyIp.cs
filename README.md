# MyIp.cs
Web-API for [myip.com](https://www.myip.com/) an website to get information about your ip address

## Example
```cs
using MyIpApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new MyIp();
            string ipInfo = await api.GetMyIp();
            Console.WriteLine(ipInfo);
        }
    }
}
```
