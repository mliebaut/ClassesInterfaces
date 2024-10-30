namespace TP_Game
{
    internal abstract class InteractiveItem : IInteractable
    {

        public Characteristic Characteristic { get; set; }
        public int Quantity { get; set; }

        public abstract void Interact(Character character);
    }
}
