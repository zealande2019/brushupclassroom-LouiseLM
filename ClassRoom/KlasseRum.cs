using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string _className;
        public List<Studerende> _classList;
        public DateTime _semesterStart;

        public string ClassName
        {
            get { return _className; }
            set { this._className = value; }
        }
        public List<Studerende> ClassList
        {
            get { return _classList; }
            //set { _classList; }

        }
        public DateTime SemesterStart
        {
            get { return _semesterStart; }
            set { this._semesterStart = value; }
        }

        public KlasseRum()
        {
        }
    }
}
