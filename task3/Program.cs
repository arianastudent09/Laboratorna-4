using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Student st = new Student("Петров В.І", 3, "85");
            Console.WriteLine($"Про студента: {st.Name},{st.Course},{st.Grade}");
            Teacher asp1 = new Teacher(st.Name, st.Course, st.Grade, "Javascript");
            Console.WriteLine($"Для викладача: {asp1.Name},{asp1.Course},{asp1.Grade},{asp1.Topic}");
            Console.ReadLine();}
        public class Student
        {   protected string name;
            protected int course; 
            protected string grade;
            public Student(string Name, int course, string grade)
            {
                this.Name = Name;
                this.course = course;
                this.grade = grade;
            }
            public string Name
            {
                get 
                { 
                    return name; 
                }
                set 
                { 
                    name = value; 
                }
            }
            public int Course
            {
                get 
                { 
                    return course; 
                }
                set 
                { 
                    course = value; 
                }
            }
            public string Grade
            {
                get 
                { 
                    return grade; 
                }
                set 
                { 
                    grade = value; 
                }
            }
        }
        public class Teacher : Student
        {
            protected string topic;            
            public Teacher(string name, int course, string grade, string topic) :
                base(name, course, grade)
            {
                
                base.name = name; 
                this.course = course; 
                this.grade = grade;
                this.topic = topic; 
            } 
            public string Topic
            {
                get 
                { 
                    return topic; 
                }
                set 
                { 
                    topic = value; 
                }
            }

           
            
        }
    }
}
