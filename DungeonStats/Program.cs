using System;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int defense;
            if (args[1] == null)
            {
                defense = 2;
            }
            else
            {
                defense = int.Parse(args[1]);
            }
        }
        private static int Damage(int attack, int defense)
        {
            if (defense > 0)
            {
                defense = 0;
            }
            return attack - defense;
        }
        private static int Damage(int attack)
        {
            return attack;
        }
        private static int CriticalHit(int damage)
        {
            if (damage <= 0)
                damage = 0;
            else
                damage = 1 + CriticalHit(damage - 1);
            return damage;
        }
    }
}
