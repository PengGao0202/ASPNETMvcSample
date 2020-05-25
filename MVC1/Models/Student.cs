using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Range(5, 50)]
        public int Age { get; set; }

        public string Gender { get; set; }


        //public override string ToString()
        //{
        //    return "ID: " + PartId + "   Name: " + PartName;
        //}
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Student objAsPart = obj as Student;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return StudentId;
        }
        public bool Equals(Student other)
        {
            if (other == null) return false;
            return (this.StudentId.Equals(other.StudentId));
        }
    }
}