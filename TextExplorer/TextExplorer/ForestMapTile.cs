using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextExplorer
{
    class ForestMapTile : MapTile
    {
        Random rand = new Random();
        
        public ForestMapTile(int x, int y, string mod)
        {
            Variant = rand.Next(1, 4);
            XPos = x;
            YPos = y;
        }

        
        public override void explore()
        {
            throw new NotImplementedException();
        }

        public override void ToString()
        {
            throw new NotImplementedException();
        }
    }
}
