using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows资源管理器.Factory;

namespace Windows资源管理器.Impl
{
    class CopyAmountImpl : CopyAmountInterface
    {
        public FileInfo[] fileInfos(string files)
        {
            DirectoryInfo dir = new DirectoryInfo(files);
            FileInfo[] f = dir.GetFiles();
            return f;
            throw new NotImplementedException();
            
        }
    }
}
