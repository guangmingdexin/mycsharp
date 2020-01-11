using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Windows资源管理器
{
    interface DriverStorageInterface
    {
         float[] showDriverStorage(String driveName);
         ManagementObjectSearcher searcher();
    }
}
