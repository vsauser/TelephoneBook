public class PhoneBook
{
    List<ContactClass> listContacts = new List<ContactClass>();

    public void addContact(string name, int telephoneNumber, string email)
    {
        ContactClass contact = new ContactClass();
        contact.Name = name;
        contact.TelephoneNumber = telephoneNumber;
        contact.Email = email;

        listContacts.Add(contact);

    }

    public void deleteContact(int index)
    {
        var contact = listContacts.FirstOrDefault(x => x.Index == index);
        listContacts.Remove(contact);
        
    }

    public void searchContact()
    {
        
        
    }
}