using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{


    public class College
    {
        private Dictionary<string, List<Student>> groupStudents = new Dictionary<string, List<Student>>();
        public void AddGroup(string name, List<Student> students)
        {
            groupStudents.Add(name, students);
        }
        public List<string> GetStudentsByGroup(string groupName)
        {
            if (groupStudents.ContainsKey(groupName))
            {
                return null;
            }
            else 
            { 
                return new List<string>(); 
            }
        }
    }
}
