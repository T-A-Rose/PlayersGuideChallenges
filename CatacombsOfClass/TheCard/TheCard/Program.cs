
using TheCard;

DisplayEachCard();

void DisplayEachCard()
{
    foreach (string cardColour in CardColour.GetNames(typeof(CardColour)))
    {
        foreach (string cardRank in CardRank.GetNames(typeof(CardRank)))
        {
            Card card = new(cardColour, cardRank);
            card.DetermineCard();
        }
    }
    Console.ReadLine();
}

public enum CardColour { Red, Green, Blue, Yellow};
public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percentage, Caret, Ampersand};
