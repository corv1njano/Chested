using System;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace Chested
{
    /// <summary>
    /// A single entry inside the MinecraftItems list which is needed for the item renderer.
    /// </summary>
    public class MinecraftItem
    {
        private readonly string _itemName;
        private readonly string _displayName;
        private readonly int _stackSize; 
        private readonly CroppedBitmap _tile;

        public MinecraftItem(string itemName, string displayName, int stackSize, CroppedBitmap tile)
        {
            _itemName = itemName;
            _displayName = displayName;
            _stackSize = stackSize;
            _tile = tile;
        }

        public MinecraftItem(string itemName, int stackSize, CroppedBitmap tile)
        {
            _itemName = itemName;
            _displayName = MainWindow.formatMinecraftName(itemName.Replace("minecraft:", string.Empty));
            _stackSize = stackSize;
            _tile = tile;
        }

        public string ItemName { get { return _itemName; } }
        public string DisplayName { get { return _displayName; } }
        public int StackSize { get { return _stackSize; } }
        public CroppedBitmap Tile { get { return _tile; } }
    }
}
