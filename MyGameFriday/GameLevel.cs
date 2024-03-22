using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                if (enemy != null)
                {
                    numenemies += 1;
                }
            }
            return numenemies;
        }
        public void PrintEnemies()
        {
            for (int i = 0; i < GetNumRooms(); i++)
            {
                if (enemies[i] != null)
                {
                    Console.WriteLine($"Room {i}: {enemies[i].GetName()}");
                }
            }
        }
    }
}