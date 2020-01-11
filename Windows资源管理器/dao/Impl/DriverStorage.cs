using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Windows资源管理器
{
    class DriverStorage:DriverStorageInterface
    {
        public float[] showDriverStorage(String driveName)
        {
            DriveInfo dinfo = new DriveInfo(driveName);

            float tsize = dinfo.TotalSize;
            float fsize = dinfo.TotalFreeSpace;

            float totalFreeSpace = dinfo.TotalFreeSpace;

            float totalSize = dinfo.TotalSize;

            float[] list = { tsize, fsize, totalFreeSpace, totalSize };
            return list;
        }

        public ManagementObjectSearcher searcher() {
            // select * from win32_logicaldisk 只读的查询语言,查询硬盘

            //SeletQuery (String)
            //整个查询或要在查询中使用的类名。
            //此类中的分析器尝试将字符串分析为有效的 WQL SELECT 查询。 
            //如果分析器不能成功分析，则假定该字符串为类名。
            SelectQuery selectQuery = new SelectQuery("select * from win32_logicaldisk");

            //基于指定的查询检索管理对象的集合,枚举系统中的所有磁盘驱动器
            //ManagementObjectSearcher (ObjectQuery)
            //下面的示例使用特定的查询初始化ManagementObjectSearcher类的新实例。
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);
            return searcher;
        }
    }
}
