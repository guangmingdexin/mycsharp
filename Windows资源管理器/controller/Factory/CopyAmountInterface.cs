using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows资源管理器.Factory
{
    interface CopyAmountInterface
    {
        FileInfo[] fileInfos(String files);
    }
}
