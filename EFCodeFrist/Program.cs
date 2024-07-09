using EFCodeFrist;
using EFCodeFrist.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            AppDbContext _context = new AppDbContext();
            var emp = new Employee {
                EmpName = "Revan",
                Address = "Qassim" 
            };

            _context.Employees.Add(emp);

            _context.SaveChanges();
        }
    }
}
