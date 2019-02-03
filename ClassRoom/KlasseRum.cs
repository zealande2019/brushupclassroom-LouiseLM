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
        }
        public List<Studerende> ClassList
        {
            get { return _classList; }
        }
        public DateTime SemesterStart
        {
            get { return _semesterStart; }
        }

        public KlasseRum()
        {
        }
    }
}
