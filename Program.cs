using EntityFrameworkDemo.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;

namespace EntityFrameworkDemo
{
    public class Program
    {

        static void Main(string[] args)
        {
            using (var ctx = new HrContext.HrContext())

            {
                var newManager = ctx.Employees.FirstOrDefault(x => x.FirstName == "Raluca" && x.LastName=="Ionescu");
                var newManagerId = new SqlParameter("@NewManagerId", newManager.Id);

                var employees = ctx.Database.SqlQuery<Employee>("exec [Hr].[ChangeManager] @NewManagerId", newManagerId)
                    .ToList();

                foreach(var employee in ctx.Employees.ToList())
                {
                    Console.WriteLine("Employee: {0} {1} {2}", employee.FirstName, employee.LastName, employee.Manager != null? employee.Manager.FullName : String.Empty);
                }
            }

            //{
            //    var job = ctx.Jobs.FirstOrDefault(x => x.JobTitle == "Internship");
            //    if (job != null)
            //    {
            //        job.MinSalary = 3;
            //        ctx.Jobs.AddOrUpdate(job);
            //        ctx.SaveChanges();
            //    }
                
            //}
            //{
            //    var employee = ctx.Employees.Include(x=>x.Department).Include(x=>x.Job).Include(x=>x.Department.Location).First();
            //    var dep = employee.Department;

            //    var employee2 = ctx.Employees.First();
            //    ctx.Entry(employee2).Reference(s => s.Department).Load();
            //}
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //    {
            //        var dep1 = ctx.Departments.FirstOrDefault(x => x.DepartmentName == "IT");

            //        if (dep1 != null)
            //        {
            //            var employees = dep1.Employees;
            //            foreach (var employee in employees)
            //            {
            //                Console.WriteLine("Employee: {0}", employee.FullName);
            //            }
            //        }
            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            //        var employeeToDelete = ctx.Employees.FirstOrDefault(x => x.Email == "ion.iulia@teamnet.ro");
            //        if(employeeToDelete !=null) // nu poate sterge ceva null
            //        {
            //            ctx.Employees.Remove(employeeToDelete);
            //            ctx.SaveChanges(); // schimbarile trebuie salvate
            //        }

            //    }


            //}
        }
    }
}
