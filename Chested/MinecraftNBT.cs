using System;

namespace Chested
{
    /// <summary>
    /// A single Minecraft NBT tag and it's value, stored in a string. Needs to be parsed if value is boolean or numeric.
    /// </summary>
    public class MinecraftNBT
    {
        private readonly string _nbtTag;
        private string nbtValue = "";

        public MinecraftNBT(string nbtTag, string value)
        {
            _nbtTag = nbtTag;
            nbtValue = value;
        }

        public string NBTTag { get { return _nbtTag; } }
        public string Value {  get { return nbtValue; } set { nbtValue = value; } }

        // TODO: move to nbt formatter in Main
        public string nbtToString(string version)
        {
            string componentPrefix = $"\"{_nbtTag}\":";

            if (version == "1.21.4")
            {
                if (_nbtTag == "minecraft:custom_name")
                {
                    return componentPrefix + $"'\"{nbtValue}\"'";
                }
            }
            return string.Empty;
        }
    }
}
