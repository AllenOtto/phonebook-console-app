// See https://aka.ms/new-console-template for more information
using PhoneBookConsole;

Contact contact1 = new Contact("Nela Simmons", "0728455490");
PhoneBook phonebook = new PhoneBook();
Console.WriteLine(phonebook.AddContact());

//Console.WriteLine($"Name: {contact1.Name}");
//Console.WriteLine($"Number: {contact1.Number}");
