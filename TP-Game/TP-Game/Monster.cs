using System.Linq.Expressions;

namespace TP_Game
{
    internal class Monster : Entity, IInteractable
    {
        public Monster()
        {
            HealthPoints = 100;
            AttackPoints = 5;
            SpeedPoints = 20;
        }

        public Monster(int healthPoints, int attackPoints, int speedPoints) : base(healthPoints, attackPoints, speedPoints)
        {
        }

        public void Combat(Entity entity) { 
            Entity entity1 = entity;
            Entity entity2 = new Monster();
        }


        public void Interact(Character character)
        {
            while (character.HealthPoints > 0 && HealthPoints > 0)
            {
                if (character.SpeedPoints > SpeedPoints && HealthPoints - character.AttackPoints > 0 && character.HealthPoints - AttackPoints > 0)
                {
                    HealthPoints = HealthPoints - character.AttackPoints;
                    character.HealthPoints = character.HealthPoints - AttackPoints;
                }
                else
                {
                    character.HealthPoints = character.HealthPoints - AttackPoints;
                    HealthPoints = HealthPoints - character.AttackPoints;
                }
                Console.WriteLine("Points de Vie actuels du Monstre: " + HealthPoints);
                Console.WriteLine("Points de Vie actuels du Personnage: " + character.HealthPoints);
            }

            if (HealthPoints > character.HealthPoints)
            {
                Console.WriteLine("Le vainqueur est Le Monstre !!!");
            }
            else Console.WriteLine("Le vainqueur est le Personnage !!!");
        }
    }
}
