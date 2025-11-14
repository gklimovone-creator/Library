// класс Fines (Штрафы)

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Entities
{
    [Table("Fines")]
    public class Fines
    {
        [Key]
        [Column("fines_id")]
        public int Fines_id { get; set; }               // Идентификатор штрафа
        
        [ForeignKey("Rentals")]
        [Column("rentals_id")]
        public int Rentals_id { get; set; }             // Идентификатор аренды
        
        [Column("amount")]
        public decimal Amount { get; set; }             // Сумма штрафа
        
        [Column("paid_amount")]
        public decimal Paid_amount { get; set; }        // Оплаченная сумма
        
        [Column("is_paid")]
        public bool Is_paid { get; set; }               // Оплачен штраф (true/false)
    }
}
