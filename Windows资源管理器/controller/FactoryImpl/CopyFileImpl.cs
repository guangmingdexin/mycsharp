using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows资源管理器.Factory;

namespace Windows资源管理器.Impl
{
    class CopyFileImpl : CopyFileInterface
    {
        public string extractFileName(string fileName)
        {
            fileName = "\\" + fileName.Substring(fileName.LastIndexOf('\\') + 1, fileName.Length - fileName.LastIndexOf('\\') - 1);//获取源文件的名称
            return fileName;
            throw new NotImplementedException();
        }
    }
}
