using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace MyGameFriday
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static int powerups = 0;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }
        public string GetName()
        {
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public static int GetPowerUps()
        {
            return powerups;
        }
        public void SetName(string new_name)
        {
            if (new_name.Length > 8)
            {
                this.name = new_name.Substring(0, 8);
            }
            else
            {
                this.name = new_name;
            }
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public void PickupPowerUp(PowerUp power, float value)
        {
            if (power == PowerUp.Health)
            {
                health += value;
                if (health > 100)
                {
                    health = 100;
                }
            }
            else if (power == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100)
                {
                    shield = 100;
                }
            }
            powerups += 1;
        }
    }
}