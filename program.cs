using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1999, 10, 27);
            DateTime exam1Date = new DateTime(2018, 12, 26);
            DateTime exam2Date = new DateTime(2018, 12, 31);
            DateTime exam3Date = new DateTime(2019, 01, 9);
            DateTime exam4Date = new DateTime(2019, 01, 19);



            Student pasha = new Student("Pasha", "Pankratov", date);
            Examination PCD = new Examination(3, "PCD", "Covtunetz", 95, true, exam1Date);
            Examination PHILOSOPHY = new Examination(3, "PHILOSOPHY", "Cutsick", 90, true, exam2Date);
            Examination OOP = new Examination(3, "OOP", "Mukha", 85, true, exam3Date);
            Examination TY = new Examination(3, "TY", "Harko", 100, true, exam4Date);
            Examination[] examArr = new Examination[4] { PCD, PHILOSOPHY, OOP, TY };

            pasha.EducationProp = 0;
            pasha.GradebookNumProp = 7109;
            pasha.GroupNumProp = "IP-71";
            pasha.PassedExamsProp = PCD;
            pasha.addExams(examArr);
                              
            Person per1 = new Person();
            Person per2 = new Person();
            Person per3 = new Person("PAsha", "PAnkratov", "02/27/2000");

            Console.WriteLine(per1);
            Console.WriteLine(per2);
            Console.WriteLine(per3);

            Console.WriteLine(per1 == per2); 
            Console.WriteLine(per1 != per3); 

            Console.WriteLine("Pashas age: ");
            mark.getPersonAge();
            Console.WriteLine();

            
            Console.WriteLine("Only exams:\n");
            foreach (Examination exam in student1.GetExams())
            {
                Console.Write(exam.ToString());
            }
            Console.WriteLine();

        }
    }
}