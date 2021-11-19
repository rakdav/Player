using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class MyMusic
    {
        public string Name { get; set; }
        public string PathName { get; set; }

        public MyMusic(string name, string pathName)
        {
            Name = name;
            PathName = pathName;
        }
    }
}
