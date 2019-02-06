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
            private set { _name = value; }
        }
        public int Birthmonth
        {
            get { return _birthmonth; }
            private set { _birthmonth = value; }
        }
        public int Birthday
        {
            get { return _birthday; }
            private set { _birthday = value; }
        }

        public Studerende(string Name, int Birthmonth, int Birthday)
        {
            Name = _name;
            Birthmonth = _birthmonth;
            Birthday = _birthday;
        }
    }
}
