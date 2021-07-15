using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee empOne = new DirectReport(1, "Sam", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture), "SPS200");
                Employee empTwo = new DirectReport(2, "Smith", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture), "SPS200");
                Employee empThree = new DirectReport(3, "Harvey", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture), "SPS200");
                Employee empFour = new DirectReport(4, "Specter", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture), "SPS200");
                Employee empFive = new DirectReport(5, "Mike", 4, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture), "SPS200");
                List<Employee> lstDirectReports = new List<Employee>();
                lstDirectReports.Add(empOne);
                lstDirectReports.Add(empTwo);
                lstDirectReports.Add(empThree);
                lstDirectReports.Add(empFour);
                lstDirectReports.Add(empFive);
                Manager manEmp = new Manager(1001, "Fred", 10, DateTime.ParseExact("01-12-2001", "dd-MM-yyyy", CultureInfo.InvariantCulture), lstDirectReports, "SPS001");

                var lst = manEmp.GetMyReports();
                foreach (var item in lst)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input");
            }
            finally
            {
                //nothing to close.
            }
        }
    }
}
