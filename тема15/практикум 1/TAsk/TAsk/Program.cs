using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk
{
    class Program 
    { 
        public static void Main(string[] args)
        {
            Studens[] st = Studens.nCreationStudents(1);
            Studens.PrintAllArray(st);

            //Sportsmens[] sp = Sportsmens.nCreationSportsmens(1);
            //Sportsmens.PrintAllArray( sp );
        }
    }
}