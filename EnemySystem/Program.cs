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

            enemyBase.Attack();
            enemyBase.TakeDamage();
            enemyBase.Die();
            Console.ReadKey();

            skeleton.Attack();
            skeleton.TakeDamage();
            Console.ReadKey();

            ghost.Attack();
            ghost.TakeDamage();
            ghost.TakeDamage();
            ghost.TakeDamage();
            ghost.TakeDamage();
            Console.ReadKey();

            boss.Attack();
            boss.Attack();
            boss.Attack();
            boss.Attack();
            boss.TakeDamage();
            Console.ReadKey();

        }
    }
    
    class EnemyBase
    {
        public int health = 50;
        public int damage = 10;
        public Random rand = new Random();

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
        public override void Attack()
        {
            if (rand.Next(7) <= 2)
            {
                Console.WriteLine($"Boss did {damage / 2} damage");
            }
            else if (rand.Next(7) <= 4)
            {
                Console.WriteLine($"Boss did {damage} damage");
            }
            else if (rand.Next(7) <= 6)
            {
                Console.WriteLine($"Boss did {damage * 2} damage");
            }
        }
    }
}
