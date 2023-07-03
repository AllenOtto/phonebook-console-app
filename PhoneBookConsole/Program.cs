using PhoneBookConsole;

PrintScreen();

PhoneBook phonebook = new PhoneBook();
var userInput = "";

while(userInput != "exit")
{
    Console.Write("Select an option or type 'exit' to quit. \n");
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.Write("Enter contact name: ");
            var name = Console.ReadLine();
            Console.Write("Enter contact number: ");
            var number = Console.ReadLine();

            Contact newContact = new Contact(name, number);
            phonebook.AddContact(newContact);

            break;
        case "2":
            Console.Write("Enter contact number to search for: ");
            var searchPhrase = Console.ReadLine();
            phonebook.DisplayMatchingContacts(searchPhrase);
            
            break;
        case "3":
            Console.Write("Enter the number to search for: ");
            var searchNumber = Console.ReadLine();
            phonebook.SearchByNumber(searchNumber);

            break;
        case "4":
            phonebook.DisplayAllContacts();

            break;
        case "exit":
            break;
        default:
            Console.WriteLine("Select valid operation");
            break;
    }
}

static void PrintScreen()
{
    Console.WriteLine("Welcome to the PHONEBOOK APP!");
    Console.WriteLine("Select Operation");
    Console.WriteLine("---------------- \n");
    Console.WriteLine("1. Add Contact to Phonebook");
    Console.WriteLine("2. Display contact by searching for a name");
    Console.WriteLine("3. Display contact by searching for a number ");
    Console.WriteLine("4. View all contacts \n");
}

