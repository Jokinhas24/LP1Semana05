using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameFriday
{
    public class GameLevel
    {
        private Difficulty difficulty;
        private Enemy[] enemies;
        public GameLevel(int rooms, Difficulty difficulty)
        {
            enemies = new Enemy[rooms];
            this.difficulty = difficulty;
        }
        public void SetEnemyInRoom(int index, Enemy enemy)
        {
            enemies[index] = enemy;
        }
        public Difficulty GetDifficulty()
        {
            return difficulty;
        }
        public int GetNumRooms()
        {
            return enemies.Length;
        }
        public int GetNumEnemies()
        {
            int numenemies = 0;
            foreach (Enemy enemy in enemies)
            {
                numenemies += 1;
            }
            return numenemies;
        }
        public void PrintEnemies()
        {
            for (int i; i < GetNumRooms(); i++)
            {
                if (enemies[i] != null)
                {

                }
                else
                {
                    Console.WriteLine($"Room {e}: {enemies[e]}");
                }
            }
        }
    }
}