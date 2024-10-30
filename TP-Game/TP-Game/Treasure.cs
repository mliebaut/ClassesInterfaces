namespace TP_Game
{
    internal class Treasure : InteractiveItem
    {

        public Treasure()
        {
            Characteristic = new Characteristic();
            Quantity = 0;
        }

        public Treasure(Characteristic characteristic, int quantity)
        {
            Characteristic = characteristic;
            Quantity = quantity;
        }

        public override void Interact(Character character)
        {
            if (Characteristic == Characteristic.attack)
            {
                character.AttackPoints += Quantity;
            }
            else if (Characteristic == Characteristic.health)
            {
                character.HealthPoints += Quantity;
            }
            else if (Characteristic == Characteristic.speed)
            {
                character.SpeedPoints += Quantity;
            }
        }

    }
}
