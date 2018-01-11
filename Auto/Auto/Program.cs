using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car passat = new Car("Vieswagen", 60, 190);

            //Console.WriteLine(passat.Fuel +" " + passat.Brand + " " +passat.MaxSpeed );

            //passat.Refuel(20);
            //Console.WriteLine(passat.Fuel + " " + passat.Brand + " " + passat.MaxSpeed);

            Monster Tredowaty = new Monster(200, 22, "I will kill you", "Tredowaty");
          
            Monster Zombie = new Monster(130, 35, "I'm slow but very deadly", "Zombie");
            Console.WriteLine("Zombie attack = "+Zombie.Attack+"hp = " + Zombie.ShowHp() );

            Tredowaty.Heal(Zombie.Attack);
            Console.WriteLine(Tredowaty.ShowHp());

            Console.ReadKey();
            
        }
    }
}
