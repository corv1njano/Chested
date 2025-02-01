using System;
using System.Windows.Media.Imaging;

namespace Chested
{
    public class InventoryEntry
    {
        private readonly int _slotId;
        private readonly List<MinecraftNBT> _minecraftNBTs = new List<MinecraftNBT>();
        private string itemName = "";
        private int amount = 1;

        public InventoryEntry(int slotId)
        {
            _slotId = slotId;
        }

        public int SlotId { get { return _slotId; } }
        public List<MinecraftNBT> MinecraftNBTs { get { return _minecraftNBTs; } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public int Amount { get { return amount; } set { amount = value; } }
    }
}
