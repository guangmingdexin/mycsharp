using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows资源管理器.Impl;

namespace Windows资源管理器.Factory
{
    class FactoryCopyFileTool
    {
        static CopyFileInterface tool = null;
        public static CopyFileInterface GetCopyFileTool()
        {
            if (tool == null)
            {
                tool = new CopyFileImpl();
            }
            return tool;
        }
    }
}
