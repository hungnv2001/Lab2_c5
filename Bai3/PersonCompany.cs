using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class PersonCompany
    {
        public int ID { get; set; }
        public string FronYear { get; set; }
        public string Curent { get; set; }
        public string Position { get; set; }
        public int Company_Id { get; set; }
        public int Person_Id { get; set; }
        public People People { get; set; }
        public Company Company { get; set; }
    }
}
