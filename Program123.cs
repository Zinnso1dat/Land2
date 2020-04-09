using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Moving += student_Moving;

            student.Move(7);
        }
        static void student_Moving(string messege)
        {
            Console.WriteLine(messege);
        }
    }
    public delegate void ShowMessege(string messege);
    public class Student
    {
        public void Move(int distance)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                if (Moving != null)
                    Moving(string.Format("Идет перемещение... пройдено километров:  {0}", i));
            }
        }
        public event Action<string> Moving;
    }
}
