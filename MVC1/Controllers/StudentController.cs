using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class StudentController : Controller
    {
        
        
        // GET: Student
        public ActionResult Index()
        {
            //MvcApplication.studentsList.Clear();
            //MvcApplication.studentsList.Add(new Models.Student { StudentId = 1, StudentName = "Peng1", Age = 19 });
            //MvcApplication.studentsList.Add(new Models.Student { StudentId = 2, StudentName = "Peng2", Age = 29 });
            //string queryString = "SELECT OrderID, CustomerID FROM dbo.Orders;";
            //using (SqlConnection connection = new SqlConnection(
            //           connectionString))
            //{
            //    SqlCommand command = new SqlCommand(
            //        queryString, connection);
            //    connection.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(String.Format("{0}, {1}",
            //                reader[0], reader[1]));
            //        }
            //    }
            //}


            return View(MvcApplication.studentsList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            Student student = new Student();
            student = MvcApplication.studentsList.Find(x => x.StudentId.Equals(id));
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                // TODO: Add insert logic here
                student.StudentId = ++ MvcApplication.globalStudentId;
                MvcApplication.studentsList.Add(student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            
            Student student = new Student();
            student = MvcApplication.studentsList.Find(x => x.StudentId.Equals(id));
            return View(student);

        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                // TODO: Add update logic here
                int index = MvcApplication.studentsList.FindIndex(x => x.StudentId.Equals(id));
                MvcApplication.studentsList[index] = student;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = new Student();
            student = MvcApplication.studentsList.Find(x => x.StudentId.Equals(id));
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student student)
        {
            try
            {
                // TODO: Add delete logic here
                int index = MvcApplication.studentsList.FindIndex(x => x.StudentId.Equals(id));
                MvcApplication.studentsList.RemoveAt(index);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
