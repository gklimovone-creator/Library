//Класс User.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("user_id")]
        public uint User_id { get; set; }                       // Идентификатор
        
        [Column("full_name")]
        public string Full_name { get; set; } = string.Empty;   // Полное имя
        
        [Column("date_of_birth")]
        public DateOnly Date_of_birth { get; set; }             // Дата рождения
        
        [Column("phone")]
        public uint Phone { get; set; }                         // Номер телефона
        
        [Column("email")]
        public string Email { get; set; } = string.Empty;       // Адрес электьронной почты
        
        [Column("role")]
        public string Role { get; set; } = string.Empty;        // Роль (Admin, Librarian, Reader)
        
        [Column("is_active")]
        public bool IsActive { get; set; }                      // Флаг активного пользователя
        
        [Column("created_at")]
        public DateOnly Created_at { get; set; }                // Дата регистрации
    }
}