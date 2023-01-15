//  Assignnment - 5
//  A card can be represented using rank (A, 2 - 10, J, Q, K) and suit(spades, diamonds, clubs, hearts).
//  A deck(or frenchdeck) is a sequence of cards(52).
//  Create two classes to implement a FrechDeck.
//  Implement the following functions:
//      1. Pick a random card from the deck
//      2. Shuffle all cards from the deck
//      3. Print a card
//      4. Print a deck
//      5. Sort the cards in a deck - A common system of ranking cards is by rank (with aces being highest),
//         then by suit in the order of spades (highest), hearts, diamonds, and clubs(lowest).


//  ['A', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K']

// [
// { Spades: ['A', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K']} 
// {Diamonds: ['A', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K']}
// {Clubs: ['A', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K']}
// {Hearts: ['A', '1', '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K']}]

using FrenchDeck;

var deck = new Deck();
Console.WriteLine("---------- Deck          ----------");
deck.Print();
Console.WriteLine("---------- Random Card   ----------");
var c1 = deck.RandomCard();
var c2 = deck.RandomCard();
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine("---------- Shuffle Cards ----------");
deck.ShuffleCards();
deck.Print();
//// Debug to compare cards
c1 = new Card(Deck.Ranks[0], Suite.Clubs);
c2 = new Card(Deck.Ranks[12], Suite.Spades);
var compare = new CardComparator();
compare.Compare(c1, c2);
Console.WriteLine("---------- Sort Deck ----------");
deck.SortDeck();
deck.Print();
