// Класс Rentals

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Entities
{
    [Table("Rentals")]
    public class Rentals
    {
        [Key]
        [Column("rentals_id")]
        public int Rentals_id { get; set; }             // Идентификатор аренды
        
        [ForeignKey("BookCopies")]
        [Column("book_copies_id")]
        public int Bookcopies_id { get; set; }          // Идентификатор копии
        
        [ForeignKey("Users")]
        [Column("user_id")]
        public int User_id { get; set; }                // Идентификатор пользователя
        
        [Column("taken_at")]
        public DateTime Taken_at { get; set; }          // Дата когда взяли книгу
        
        [Column("due_date")]
        public DateOnly Due_date { get; set; }          // Когда должны вернуть (рассчитывается)
        
        [Column("returned_at")]
        public DateTime Returned_at { get; set; }       // Когда вернули книгу
    }
}
