using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows资源管理器.Impl;

namespace Windows资源管理器.Factory
{
    class FactoryCopyAmountTool
    {
        static CopyAmountInterface tool = null;
        public static CopyAmountInterface GetCopyAmountTool()
        {
            if (tool == null)
            {
                tool = new CopyAmountImpl();
            }
            return tool;
        }
    }
}
