using System;
using System.Collections.Generic;
using System.Text;

namespace barApplication
{
    class BarPerson 
    {
        Glass currentGlass = null;

        public void GetGlass( string typeOfGlass)
        {
            if (typeOfGlass == "pint")
            {
                currentGlass = new PintGlass();
            }
            else if(typeOfGlass == "wine" )
            {
                currentGlass = new WineGlass();
            }
        }

        public void PourDrink()
        {

        }

    }


}
