using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Lib
{
    public class PluginType:Attribute
    {
        public string Extension { set; get; }
        public PluginType(string extension)
        {
            Extension = extension;
        }
    }
}
