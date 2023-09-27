using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Country
    {
        public string? name { get; set; }
        public string? code { get; set; }
        public override string ToString()
        {
            return "name:" + name + "," + "code:" + code;
        }
    }

}
