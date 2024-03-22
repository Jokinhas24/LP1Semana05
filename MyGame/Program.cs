using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            Enemy[] Enemies = new Enemy[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string name = Console.ReadLine();
                Enemy enemyname = new Enemy(name);
                Enemies[i] = enemyname;
            }

            foreach (Enemy e in Enemies)
            {
                Console.WriteLine($"{e.GetName()} {e.GetHealth()} {e.GetShield()}");
            }
        }
    }
}
