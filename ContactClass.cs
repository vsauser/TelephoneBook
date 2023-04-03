public class ContactClass
{
    public string Name {get; set;}
    public int TelephoneNumber {get; set;}
    public string Email {get; set;}
    public int Index {get; set;}

    public ContactClass()
    {
       Index = IncrementClass.GetIndex();
    }

}