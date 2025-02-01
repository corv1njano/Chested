using System;
using System.Globalization;

namespace Chested
{
    /// <summary>
    /// A single entry inside the MinecraftEnchantments list which is needed for the enchantment renderer. 
    /// </summary>
    public class MinecraftEnchantment
    {
        private readonly string _enchantmentName;
        private readonly string _displayName;
        private readonly int _maxLevel;
        private readonly List<string> _validItems = new List<string>();

        public MinecraftEnchantment(string enchantmentName, string displayName, int maxLevel, List<string> validItmes)
        {
            _enchantmentName = enchantmentName;
            _displayName = displayName;
            _maxLevel = maxLevel;
            _validItems = validItmes;
        }

        public MinecraftEnchantment(string enchantmentName, int maxLevel, List<string> validItmes)
        {
            _enchantmentName = enchantmentName;
            _displayName = MainWindow.formatMinecraftName(enchantmentName.Replace("minecraft:", ""));
            _maxLevel = maxLevel;
            _validItems = validItmes;
        }

        public string EnchantmentName { get { return _enchantmentName; } }
        public string DisplayName { get { return _displayName; } }
        public int MaxLevel { get { return _maxLevel; } }
        public List<string> ValidItems { get { return _validItems; } }
    }
}
