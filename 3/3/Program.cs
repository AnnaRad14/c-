using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bullet bullet = new Bullet(25);
            Enemy enemy = new Enemy(50);
            BreakableWall wall = new BreakableWall(30);
            Console.WriteLine("Куля летить у ворога:");
            bullet.HitTarget(enemy);

            Console.WriteLine();


            Console.WriteLine("Куля летить у стіну:");
            bullet.HitTarget(wall);

            Console.ReadLine();
        }
    }
}
