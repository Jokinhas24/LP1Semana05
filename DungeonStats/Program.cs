using System;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int defense;
            if (args.Length == 1)
            {
                defense = 2;
            }
            else
            {
                defense = int.Parse(args[1]);
            }
            int damage = Damage(int.Parse(args[0]));
            int defdamage = Damage(int.Parse(args[0]), defense);
            int critdamage = CriticalHit(defdamage);

            var table = new Table();
  
            // Add columns
            table.AddColumn("Operation");
            table.AddColumn("Result");
  
            // Add rows
            table.AddRow($"Damage({damage})", $"{damage}");
            table.AddRow($"Damage({damage}, {defense})", $"{defdamage}");
            table.AddRow($"CriticalHit({defdamage})", $"{critdamage}");
  
            AnsiConsole.Write(table);
        }
        private static int Damage(int attack, int defense)
        {
            if (defense < 0)
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
            {
                damage = 0;
            }
            else
            {
                damage += CriticalHit(damage - 1);
            }
            return damage;
        }
    }
}
