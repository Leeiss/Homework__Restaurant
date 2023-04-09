using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__Restaurant
{
    internal class Tabledetails
    {
        public class TableDetails
        {
            public Table Table { get; set; }
            public Fio Fio { get; set; }
            public string Date { get; set; }
            public Details Details { get; set; }
        }

        public class Table
        {
            public int Number { get; set; }
        }

        public class Fio
        {
            public string Name { get; set; }
            public string Surname { get; set; }
        }

        public class Details
        {
            public int Persons { get; set; }
            public string Event { get; set; }
        }
    }
}
