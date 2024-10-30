namespace TP_Game
{
    internal class Character : Entity
    {
        public Character()
        {
            HealthPoints = 100;
            AttackPoints = 5;
            SpeedPoints = 20;
        }

        public Character(int healthPoints, int attackPoints, int speedPoints) : base(healthPoints, attackPoints, speedPoints)
        {
        }

        public void DisplayCharacteristics()
        {
            Console.WriteLine("HP: " + HealthPoints + "\nAP: " + AttackPoints + "\nSP: " + SpeedPoints);
        }
    }
}
