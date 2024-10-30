using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Game
{
    internal class Entity
    {

        public int HealthPoints { get; set; }
        public int AttackPoints { get; set; }
        public int SpeedPoints { get; set; }

        public Entity()
        {
            HealthPoints = 100;
            AttackPoints = 5;
            SpeedPoints = 20;
        }

        public Entity(int healthPoints, int attackPoints, int speedPoints)
        {
            HealthPoints = healthPoints;
            AttackPoints = attackPoints;
            SpeedPoints = speedPoints;
        }
    }
}
