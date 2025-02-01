using System;
using System.Windows.Media.Imaging;

namespace Chested
{
    /// <summary>
    /// A ComboBoxItem for container selection.
    /// </summary>
    public class ContainerType
    {
        private readonly string _containerName;
        private readonly string _displayName;
        private readonly CroppedBitmap _tile;

        public ContainerType(string containerName, string displayName, CroppedBitmap tile)
        {
            _containerName = containerName;
            _displayName = displayName;
            _tile = tile;
        }

        public string ContainerName { get { return _containerName; } }
        public string DisplayName { get { return _displayName; } }
        public CroppedBitmap Tile { get { return _tile; } }
    }
}
