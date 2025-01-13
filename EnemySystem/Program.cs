using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnemyBase enemyBase = new EnemyBase();
            Skeleton skeleton = new Skeleton();
            Ghost ghost = new Ghost();
            Boss boss = new Boss();


        }
    }
    
    class EnemyBase
    {
        public int health = 50;
        public int damage = 10;

        public virtual void Attack()
        {
            Console.WriteLine($"Did {damage} damage!");
            Console.ReadKey();
        }
        public virtual void TakeDamage()
        {
            Console.WriteLine($"Took {damage} damage!");
            Console.ReadKey();
        }
        public virtual void Die()
        {
            Console.WriteLine("You Died");
            Console.ReadKey();
        }
    }
    class Skeleton : EnemyBase
    {
    }
    class Ghost : EnemyBase
    {
        public override void TakeDamage()
        {
            Random rand = new Random();
            if (rand.Next(5) >= 3)
            {
                Console.WriteLine($"Ghost took {damage} damage");
            } 
            else
            {
                Console.WriteLine("You missed!");
            }
        }
    }
    class Boss : EnemyBase
    {

    }
}
