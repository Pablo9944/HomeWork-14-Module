using HomeWork_14_Module;

class Program
{
    static void Main()
    {
        var phoneBook = new List<Contact>();

        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

        var resultPhoneBook = phoneBook
                              .OrderBy(name => name.Name)
                              .ThenBy(surname => surname.LastName);

        foreach (var e in resultPhoneBook)
            Console.WriteLine(e.Name + " " + e.LastName);
     

    }
}