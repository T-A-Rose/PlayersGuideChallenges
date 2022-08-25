
DisplayEachCard();

int DisplayEachCard()
{
    foreach (int i in CardColour.GetValues(typeof(CardColour))){
        Console.WriteLine(i);
    }
    return 1;
}

public class Card
{
    CardColour CC;
    CardRank CR;

    public Card(CardColour _CC, CardRank _CR)
    {
        CC = _CC;
        CR = _CR;
    }

    public CardColour DetermineCard()
    {
        return new CardColour();
    }

}

public enum CardColour { red, green, blue, yellow};
public enum CardRank { one = 1, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9, ten = 10, dollar = 11, percentage = 12, Caret = 13, ampersand = 14};
