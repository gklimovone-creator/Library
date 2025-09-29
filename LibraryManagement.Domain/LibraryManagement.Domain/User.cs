//Класс User.

namespace LibraryManagement.Domain.Entities
//namespace LibraryManagement.Domain.LibraryManagement.Domain
{

    public class User
    {
        public uint Id { get; set; }                            // Идентификатор
        public string FullName { get; set; } = string.Empty;    // Полное имя
        public DateOnly DateOfBirth { get; set; }               // Дата рождения
        public uint Phone { get; set; }                         // Номер телефона
        public string Email { get; set; } = string.Empty;       // Адрес электьронной почты
        public string Role { get; set; } = string.Empty;        // Роль
        public bool IsActive { get; set; }                      // Флаг активного пользователя
    }
}