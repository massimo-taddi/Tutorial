using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadByFile
{
    internal interface IDAO
    {
        public void ReadFromInfo(string[] info);
        public void AddValues();
        public string PrintObject();
    }
}
