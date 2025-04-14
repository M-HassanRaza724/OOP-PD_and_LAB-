namespace CardGame.BL
{
    class Hand
    {
        protected List<Card> Cards;
        public Hand()
        {
            Cards = new List<Card>();
        }

        public void clear()
        {
            Cards.Clear();
        }

        public void AddCard(Card c)
        {
           Cards.Add(c);
        }
        public void RemoveCard(Card c)
        {
           Cards.Remove(c);
        }
        public int GetCardCount()
        {
          return Cards.Count();
        }
        public void removeCard(int position)
        {
            if(Cards.Count() >= position)
                Cards.RemoveAt(position);
        }

        public Card GetCard(int position)
        {
            return Cards[position];
        }


        public void SortBySuit()
        {
            Cards = Cards.OrderBy(o => o.getSuit()).ToList();
        }


        public void sortByValue()
        {
            Cards = Cards.OrderBy(o => (o.getValue()+o.getSuit())).ToList();
        }
    }
}
