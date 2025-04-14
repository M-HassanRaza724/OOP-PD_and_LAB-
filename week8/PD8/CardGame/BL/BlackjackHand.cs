using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.BL
{
    class BlackjackHand : Hand
    {
        public BlackjackHand()
        {
            Cards = new List<Card>();
        }
        public int GetValue()
        {
            int value = 0;
            int aces = 0;
            foreach (Card card in Cards)
            {
                if (card.getValue() == 1)
                {
                    aces++;
                    value += 11;
                }
                else if (card.getValue() >= 10)
                {
                    value += 10;
                }
                else
                {
                    value += card.getValue();
                }
            }
            // Adjust for Aces if value exceeds 21
            while (value > 21 && aces > 0)
            {
                value -= 10;
                aces--;
            }
            return value;
        }
    }
}
