/*
 
Memory Based Address Book:

Contact {
FirstName, LastName, Phone, Email
}

AddressBook {
AddContact(Contact contact)
RemoveContact(Contact contact)
SortContacts()
PrintContacts()
}
*/

var addressBook = new AddressBook();
List<Contact> cachedContacts = new List<Contact>();

int count = 5;

for (int i = 0; i < count; i++)
{
    string firstName = string.Empty;
    string lastName = string.Empty;
    string phoneNumber = string.Empty;
    string emailAddress = string.Empty;
    Console.Write("Enter first name : ");
    firstName = Console.ReadLine();
    Console.Write("Enter last name : ");
    lastName = Console.ReadLine();
        Console.Write("Enter phone number : ");
    phoneNumber = Console.ReadLine();
    Console.Write("Enter email address : ");
    emailAddress = Console.ReadLine();

    var contact = new Contact(firstName, lastName, phoneNumber, emailAddress);
    addressBook.AddContact(contact);
    cachedContacts.Add(contact);

}


Console.WriteLine("Printing contacts");
addressBook.PrintContacts();

Console.WriteLine("Sorting contacts");
addressBook.SortContacts();


for (int i = 0; i < count; i++)
{
    Console.WriteLine("Removing contact" + cachedContacts[i]);
    addressBook.RemoveContact(cachedContacts[i]);
    addressBook.PrintContacts();
}


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