using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFrist.Models
{
    public class Employee
    {
        public Employee()
        {

        }

        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
    }
}
