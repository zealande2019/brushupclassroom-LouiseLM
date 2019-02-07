using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum KlasseRum = new KlasseRum();
            KlasseRum.ClassName = "3B";
            KlasseRum.SemesterStart = new DateTime (2018, 9, 4);
            //KlasseRum.SemesterStart.Month

            //Studerende elev1 = new Studerende("Louise", 5, 4);
            KlasseRum.ClassList.Add(new Studerende("Louise", 5, 4));
            Studerende elev2 = new Studerende("Luca", 12, 28);
            KlasseRum.ClassList.Add(elev2);
            Studerende elev3 = new Studerende("Martin", 6, 13);
            KlasseRum.ClassList.Add(elev3);

            Console.WriteLine(KlasseRum.ClassName);

            foreach (var item in KlasseRum.ClassList)
            {
                //Console.WriteLine(item.Name + " har fødselsdag d. " + item.Birthday + "/" + item.Birthmonth);
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();

        }
    }
}
