public class AddressBook
{
    // Fields
    private readonly List<Contact> _contact;

    public AddressBook()
    {
        _contact = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        _contact.Add(contact);
    }

    public void RemoveContact(Contact contact)
    {
        _contact.Remove(contact);
    }

    public void SortContacts()
    {

        ContactSortByName sortByName = new ContactSortByName();
        _contact.Sort(sortByName);
        foreach (var contact in _contact)
        {
            Console.WriteLine(contact);
        }
    }

    public void PrintContacts()
    {
        foreach (var item in _contact)
        {
            Console.WriteLine(item);
        }
    }
}