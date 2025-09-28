//Класс User.

namespace LibraryManagement.Domain
{

    public class User
    {
        public uint Id;                 // Идентификатор
        public string FullName;         // Полное имя
        public DateOnly DateOfBirth;    // Дата рождения
        public uint Phone;              // Номер телефона
        public string Email;            // Адрес электьронной почты
        public string Role;             // Роль
        public bool IsActive;           // Флаг активного пользователя
    }
}