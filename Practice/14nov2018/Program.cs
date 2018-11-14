using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14nov2018
{
    class CommonDetails
    {
        int Id;
         public string Name;
        

        public string _name             // Encapsulation(Getter and Setter)
        {
            get
            {
                return  Name;
                    
            }
            set
            {
                Name = value;
            }

        }

        public CommonDetails()              // constructor
        {
            Console.WriteLine("this is first constructor");

        }
        public CommonDetails(int Id, string Name)           // Constructor Overloading
        {
            this.Id = Id;
            this.Name = Name;
            Console.WriteLine(this.Id);
            Console.WriteLine(this.Name);
          
        }
        public CommonDetails(int Id)
        {
            Console.WriteLine("this is third constructor");
        }
    }
    
    class Course 
    {
        public int fees;
        
        public virtual void GetCourseDetails()              // Method overriding
        {
            Console.WriteLine("Enter the course Fee");
            fees = Convert.ToInt16(Console.ReadLine());
        }

        public virtual void DisplayCourseDetails()
        {
            Console.WriteLine("Course Fee is : " + fees);
        }
    }

    class JavaCourse : Course
    {
        int Duration;

        public override void GetCourseDetails()
        {
            Console.WriteLine("Enter the course Fee");
            fees = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the course Duraton");
            Duration = Convert.ToInt16(Console.ReadLine());
        }

        public override void DisplayCourseDetails()
        {
            Console.WriteLine("Display the Java Course Details");
            Console.WriteLine("Fees : " + fees + ", Duration " + Duration);
        }
    }

    public class launch
    {
        static void Main(string[] args)

        {
            CommonDetails CD = new CommonDetails();
            CD._name = "roshini";
            Console.WriteLine(CD._name);

            CommonDetails C = new CommonDetails(1,"manasa");

            Course c = new Course();
            c.GetCourseDetails();
            c.DisplayCourseDetails();

            JavaCourse jc = new JavaCourse();
            jc.GetCourseDetails();
            jc.DisplayCourseDetails();
            
            Console.ReadKey();
        }
    }    
}
