using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    public class Company
    {
        public string Name { get; set; }
        [Key]
        public int Id {  get; set; }
        public List<PersonCompany> PersonCompany { get; set; }
    }
}
