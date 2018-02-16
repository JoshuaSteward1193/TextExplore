using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextExplorer
{
    abstract class MapTile
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int Variant { get; set; }

        public string TileModifier { get; set; }
        public string Description { get; set; }
        
        public MapTile()
        {

        }
        public MapTile(int x, int y)
        {
            XPos = x;
            YPos = y;
            TileModifier = "none";
        }
        public MapTile(int x, int y, string mod)
        {
            XPos = x;
            YPos = y;
            TileModifier = mod;
        }
        public abstract void 
        public abstract void explore();
        public abstract void ToString();
        
    }
}
