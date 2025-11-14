//Класс Author.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Entities
{
    [Table("Author")]
    public class Author
    {
        [Key]
        [Column("author_id")]
        public int Author_id { get; set; }                      //Идентификатор

        [Column("full_name")]
        public string Full_name { get; set; } = string.Empty;   //Полное имя (ФИО)

        [Column("country")]
        public string Country { get; set; } = string.Empty;     //Страна

        [Column("email")]
        public string Email { get; set; } = string.Empty;       //Электронная почта
    }
}