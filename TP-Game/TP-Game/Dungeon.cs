namespace TP_Game
{
    internal class Dungeon
    {
        public List<IInteractable> ItemList { get; set; }

        public Dungeon(List<IInteractable> itemList)
        {
            ItemList = itemList;
        }

        public void ExploreCharacter(Character character)
        {
            foreach (InteractiveItem item in ItemList)
            {
                item.Interact(character);
                character.DisplayCharacteristics();
            }
        }
    }
}
