using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private string _name;
        private int _birthmonth;
        private int _birthday;

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

        public Studerende(string name, int birthmonth, int birthday)
        {
            Name = name;
            Birthmonth = birthmonth;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return (Name + " har fødselsdag d. " + Birthday + "/" + Birthmonth);
        }



        //public string Årstid()
        //{
        //    if (Birthmonth = [12, 1, 2])
        //    {
        //        return "vinter";
        //    }
        //    else if (Birthmonth = [3, 4, 5])
        //    {
        //        return "Forår";
        //    }
        //    else if (Birthmonth = [6, 7, 8])
        //    {
        //        return "Sommer";
        //    }
        //    else if (Birthmonth = [9, 10, 11])
        //    {
        //        return "Efterår";
        //    }
        //}
    }
}
