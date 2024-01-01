import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

public class Deck {
    private Card[] deck;
    private int currentCard = 0;
    private ArrayList<Card> cards;

    public Deck() {
        cards = new ArrayList<>();
        for (Suit suit : Suit.values()) {
            for (Rank rank : Rank.values()) {
                cards.add(new Card(suit, rank));
            }
        }
        shuffle();
    }

    public void shuffle() {
        Collections.shuffle(cards);
    }

    public Card drawCard() {
        return deck[currentCard++];
    }

    public void print() {
        for (Card card : cards) {
            System.out.println(card);
        }
    }


}
