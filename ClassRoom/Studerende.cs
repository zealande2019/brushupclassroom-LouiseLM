using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string _name;
        public int _birthmonth;
        public int _birthday;

        public string Name
        {
            get { return _name; }
        }
        public int Birthmonth
        {
            get { return _birthmonth; }
        }
        public int Birthday
        {
            get { return _birthday; }
        }

        public Studerende(string Name, int Birthmonth, int Birthday)
        {
            Name = _name;
            Birthmonth = _birthmonth;
            Birthday = _birthday;
        }
    }
}
