using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classse_et_stucrur
{
    class Program
    {
        static void Main(string[] args)


        {
            Student[] studentArray = {
                new Student() { studentId = 1, studentName = "John", age = 18 } ,
                new Student() { studentId = 2, studentName = "Steve",  age = 21 } ,
                new Student() { studentId = 3, studentName = "Bill",  age = 25 } ,
                new Student() { studentId = 4, studentName = "Ram" , age = 20 } ,
                new Student() { studentId = 5, studentName = "Ron" , age = 31 } ,
                new Student() { studentId = 6, studentName = "Chris",  age = 17 } ,
                new Student() { studentId = 7, studentName = "Rob",age = 19  } ,
            };

            Student[] students = new Student[10];
            int i = 0;
            foreach (Student std in  studentArray )
            {
                if (std.age > 12 && std.age < 20)
                    students[i++] = std; 
            }

            foreach (Student std in studentArray)
            {

                if (std != null)
                {
                    
                    Console.WriteLine("id:{0}" , std.studentId);
                }
                else
                {
                    break;
                }
                
            }

        }
    }
}
