using _3.Lab3;
using System;

namespace _3
{
    public class BreakableWall : IDamageable
    {
        private int strength;

        public BreakableWall(int strength)
        {
            this.strength = strength;
        }

        public void TakeDamage(int damage)
        {
            strength -= damage;
            Console.WriteLine($"Стіна отримала {damage} шкоди. Міцність: {strength}");

            if (strength <= 0)
            {
                Console.WriteLine("Стіна зруйнована!");
            }
        }
    }
}
