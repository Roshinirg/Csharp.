using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14NOV
{
    class CommonDetails
    {
        string name;
        int Id;

        public CommonDetails()
        {
            Console.WriteLine("THIS IS ZERO PARAMETER CONSTRUCTOR");
            name = "ABC";
            Id = 100;
           
        }

        public CommonDetails(string name)
        {
            this.name = name;
        }

        public CommonDetails(int Id)
        {
            this.Id = Id;
        }
        

        
    }
    class player : CommonDetails
    {
        int score;

        public player()
        {

            Console.WriteLine("THIS IS PLAYER CLASS CONSTRUCTOR");
           
            
        }

        public player(string nm) : base ( nm)
        {
            Console.WriteLine("name is:"+nm);
            
        }
        public player(int Id) : base (Id)
        {
            Console.WriteLine("player's id is"+Id);
        }
        
        
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            player p = new player();
            player p1 = new player("virat");
            player p2 = new player(2);

            
            Console.ReadLine();

        }
    }
}
