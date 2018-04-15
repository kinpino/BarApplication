using System;
using System.Collections.Generic;
using System.Text;

namespace barApplication
{
    public class Glass : IGlass
    {
       public int volume = 0;

        
        public int maxVolume = 0;

        public string liquid = null;

        public string GetLiquid()
        {
            return liquid;
        }

        public int GetMaxVolume()
        {
            return maxVolume;
        }

        public int GetVolume()
        {
            return volume;
        }
    }
}
