class ContactSortByName : IComparer<Contact>
{
    public int Compare(Contact contact1, Contact contact2)
    {
        return string.Compare(contact1.FirstName, contact2.FirstName);
    }
}