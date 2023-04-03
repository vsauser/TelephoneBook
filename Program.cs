// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PhoneBook phoneBook = new PhoneBook();
phoneBook.addContact("Sergey", 23634, "varlamov2@mail.ru");
phoneBook.addContact("Andrey", 35403, "varlamov@mail.ru");
phoneBook.addContact("Ivan", 12345, "varlamov10@mail.ru");

phoneBook.deleteContact(2);

Console.ReadLine();