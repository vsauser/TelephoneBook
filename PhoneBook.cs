public class PhoneBook
{
    List<ContactClass> listContacts = new List<ContactClass>();
    ContactClass contactClass = new ContactClass();

    public void addContact()
    {
        contactClass.firstName = Console.ReadLine();
        listContacts.Add(contactClass.firstName);

    }

    public void deleteContact()
    {
        
    }

    public void searchContact()
    {
        
    }
}