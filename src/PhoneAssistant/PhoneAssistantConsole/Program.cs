using PhoneAssistantConsole.CRUD;

var contactService = new ContactService();

while (true)
{
    Console.WriteLine("\nТелефонный справочник:");
    Console.WriteLine("1. Добавить контакт");
    Console.WriteLine("2. Удалить контакт");
    Console.WriteLine("3. Обновить контакт");
    Console.WriteLine("4. Найти контакт");
    Console.WriteLine("5. Показать все контакты");
    Console.WriteLine("0. Выход");
    Console.Write("Выберите действие: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите номер телефона: ");
            var phoneNumber = Console.ReadLine();
            contactService.AddContact(name!, phoneNumber!);
            break;

        case "2":
            Console.Write("Введите Id контакта для удаления: ");
            var idToDelete = int.Parse(Console.ReadLine() ?? "0");
            contactService.DeleteContact(idToDelete);
            break;

        case "3":
            Console.Write("Введите Id контакта для обновления: ");
            var idToUpdate = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите новое имя: ");
            var newName = Console.ReadLine();
            Console.Write("Введите новый номер телефона: ");
            var newPhoneNumber = Console.ReadLine();
            contactService.UpdateContact(idToUpdate, newName!, newPhoneNumber!);
            break;

        case "4":
            Console.Write("Введите имя или часть имени для поиска: ");
            var query = Console.ReadLine();
            var results = contactService.SearchContacts(query!);
            if (results.Any())
            {
                foreach (var contact in results)
                {
                    Console.WriteLine($"Id: {contact.Id}, Имя: {contact.Name}, Телефон: {contact.PhoneNumber}, Email: {contact.Description}");

                }
            }
            else
            {
                Console.WriteLine("Контакты не найдены.");
            }
            break;

        case "5":
            var allContacts = contactService.GetAllContacts();
            if (allContacts.Any())
            {
                foreach (var contact in allContacts)
                {
                    Console.WriteLine($"Id: {contact.Id}, Имя: {contact.Name}, Телефон: {contact.PhoneNumber}, Email: {contact.Description}");
                }
            }
            else
            {
                Console.WriteLine("Контакты отсутствуют.");
            }
            break;

        case "0":
            Console.WriteLine("Выход.");
            return;

        default:
            Console.WriteLine("Неверный выбор.");
            break;
    }
}