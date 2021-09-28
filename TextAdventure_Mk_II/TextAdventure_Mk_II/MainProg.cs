using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure_Mk_II
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            String usrIn;
            Random Rand = new Random();
            Console.WriteLine("Hello!");
            Entity Guy1 = new Entity("Guy1","A Guy", 30,0,0,4,Stats.RetStats(3,4,5),Stats.RetStats(1,2,3));
            Guy1.addItemToInv(Useful.ElectroSword);
            Guy1.addItemToInv(Useful.Helmet);
            Guy1.addItemToInv(Useful.Robe);
            Entity Guy2 = new Entity("Guy2", "SecondGuy", 30, 0, 0, 4, Stats.RetStats(5, 1, 3), Stats.RetStats(-3, -2, 5));
            Guy2.addItemToInv(Useful.CrushingMaul);
            Guy2.addItemToInv(Useful.FlakJacket);
            Console.ReadKey();
            Console.WriteLine("\n\t--------------------\n");
            Guy1.PrintChar();
            Console.ReadKey();
            Console.WriteLine("\n\t--------------------\n");
            Guy2.PrintChar();
            Console.ReadKey();
            Console.WriteLine("Enter 1 to continue onto the fight enter 2 to go to the shop, enter 3 to quit");
            usrIn = Console.ReadLine();
            if (usrIn == "1")
            {
                Console.WriteLine("THE FIGHT!");

                Useful.FightRound(Guy1, Guy2, Rand);
                Console.WriteLine("\n\t Guy1 HP:{0}\n\t Guy2 HP:{1}",Guy1.getHPRatio(),Guy2.getHPRatio());
                Console.ReadKey();
                Useful.FightRound(Guy1, Guy2,Rand);
                
                Console.ReadKey();
                Useful.FightRound(Guy1, Guy2, Rand);
                Console.WriteLine("\n\t Guy1 HP:{0}\n\t Guy2 HP:{1}", Guy1.getHPRatio(), Guy2.getHPRatio());
                Console.ReadKey();
                Console.WriteLine("\n\t--------------------\n");
                Guy1.PrintChar();
                Console.WriteLine("\n\t--------------------\n");
                Guy2.PrintChar();
            }
            else if (usrIn == "2")
            {
                Console.WriteLine("THE SHOP!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("goodbye!");
                Console.ReadKey();
            }
        }
    }
}
