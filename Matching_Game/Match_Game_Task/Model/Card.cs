using System.Drawing;

//Encapsulates card properties:

namespace Matching_Game_Task.Model
{
    public class Card
    {
        public Image card_Image;
        public int card_Type;
        public bool matched;


        public Card(int num, Image image)
        {
            card_Type = num;
            matched = false;
            card_Image = new Bitmap(image);
        }
    }
}
