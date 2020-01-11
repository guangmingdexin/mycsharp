using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows资源管理器
{
    class NetDriverImpl : NetDriverInterface
    {
        public string[] dirName()
        {
            int j = 0;
            string[] str = new string[26];
            for (int i = 65; i < 91; i++)
            {
                str[j] = Convert.ToChar(i).ToString() + ":";
                j++;
            }
            return str;
            throw new NotImplementedException();
        }
    }
}
