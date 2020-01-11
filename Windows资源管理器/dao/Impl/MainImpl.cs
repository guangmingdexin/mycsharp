using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows资源管理器
{
    class MainImpl : MainInterface
    {
        public  String showDate()
        {
            return "日期:" + DateTime.Now.ToString();
            throw new NotImplementedException();
        }
    }
}
