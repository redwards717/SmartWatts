using SmartWattsCore.Models;
using System.Collections.Generic;
using System.IO;

namespace SmartWattsCore.Services
{
    public interface IXmlServices
    {
        Ride ParseGpx(MemoryStream xmlMs);
        Ride ParseTcx(MemoryStream xmlMs);
    }
}