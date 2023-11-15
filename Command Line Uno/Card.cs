using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Line_Uno
{
    public class Card
    {
        private string colour;
        private string face;

        public Card(string cardFace, string cardColour)
        {
            colour = cardColour;
            face = cardFace;
        }

        public override string ToString()
        {
            return colour + " " + face;
        }  
    }
}
