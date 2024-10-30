namespace TP_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Character character1 = new Character(200, 12, 7);
            Trap trap1 = new Trap(Characteristic.attack, 1);
            Trap trap2 = new Trap(Characteristic.health, 20);
            Treasure treasure1 = new Treasure(Characteristic.speed, 60);
            Dungeon dungeon1 = new Dungeon([trap1, trap2, treasure1]);


            Console.WriteLine("Points de vie : " + character1.HealthPoints);
            trap1.Interact(character1);
            Console.WriteLine( trap1.Characteristic + " réduite de " + trap1.Quantity + " points aie aie aie !! ");
            Console.WriteLine("Tu frappes désormais à : " + character1.AttackPoints + " points");
            treasure1.Interact(character1);
            Console.WriteLine("Par contre tu cours à " + character1.SpeedPoints + "km/h... énorme non ? :D");
            trap2.Interact(character1);
            Console.WriteLine("AÏE tu viens de perdre " + trap2.Quantity + " points de vie... :(");

            Monster monster1 = new Monster(100, 2, 8);
            character1.DisplayCharacteristics();

            monster1.Interact(character1);
            character1.DisplayCharacteristics();


        }
    }
}
