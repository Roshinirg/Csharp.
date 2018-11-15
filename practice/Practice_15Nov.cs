using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15nov2018
{
    class Program
    {
        static void Main(string[] args)
        {

            Team t= new Team();
            t.details();              
            Player p = new Player();
            p.details();               // calling Abstract class method
            p.idetails();             // interface method call
            Console.WriteLine(t.Id);    
            Console.WriteLine(p.Id);
            IDetails p1 = new Player();  // using Interface
            p1.idetails();
            Console.ReadLine();

        }
    }

class Player : Details, IDetails           // inherithing an abstract class and interface 
    {

        public void idetails()
        {
            Console.WriteLine("Interface: Player_details");
        }
        public override int Id
        {
            get                   // using getters
            {
                return _Id=30;
            }              
          
        }

        public override void details()
        {

            Console.WriteLine("Enter player name");
            Player_Name = Console.ReadLine();
            Console.WriteLine("Enter score player");
            Score_Of_Player = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("player name= " + Player_Name + " player score= " + Score_Of_Player);
          

        }
        void  IDetails.idetails()
        {
            Console.WriteLine("IDetails.idetails()");
        }
    }
class Team: Details
    {

        public override void details()
        {
            Console.WriteLine("Enter team name");
            Team_name = Console.ReadLine();
            Console.WriteLine("Enter no of players in team");
            No_of_Players = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("team name= " + Team_name + " no of players= " + No_of_Players);
           
        }
        public override int Id
        {
            get
            {
                return _Id = 20;
            }
            
        }

    }

interface IDetails
    {
         void idetails();
    }
    abstract class Details
    {
        public string Team_name;
        public int No_of_Players;
        public string Player_Name;
        public int Score_Of_Player;
        protected int _Id;


        public abstract int Id { get; }

        public abstract void details();

        public  void New_details()
        {
            Console.WriteLine("New details");
        }

    }
}
