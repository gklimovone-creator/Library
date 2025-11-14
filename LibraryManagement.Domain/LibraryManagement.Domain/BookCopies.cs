//Класс BookCopies.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Entities
{
    [Table("BookCopies")]
    public class BookCopies
    {
        [Key]
        [Column("book_copirs_id")]
        public int Book_copirs_id { get; set; }         // Идентификатор копии
        
        [ForeignKey("Book")]
        [Column("book_i")]
        public int Book_id { get; set; }                // Идентификатор книги
       
        [Column("is_available")]
        public bool Is_available { get; set; }          // Доступна для аренды
    }
}
