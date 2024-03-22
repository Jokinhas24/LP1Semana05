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

            Enemies[0].TakeDamage(80);
            Enemies[0].PickupPowerUp(PowerUp.Health,30);
            
            Enemies[1].PickupPowerUp(PowerUp.Shield,40);
            Enemies[1].TakeDamage(135);
            Enemies[1].PickupPowerUp(PowerUp.Health,70);

            foreach (Enemy e in Enemies)
            {
                Console.WriteLine($"{e.GetName()} {e.GetHealth()} {e.GetShield()}");
            }
            
        }
    }
}
