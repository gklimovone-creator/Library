// класс MassageQueue
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace LibraryManagement.Domain.Entities
{
    [Table("MessageQueue")]
    public class MessageQueue
    {
        [Key]
        [Column("massege_id")]
        public int Massege_id { get; set; }
        
        [Required]                                                      // "Это поле НЕ МОЖЕТ быть NULL"
        [Column("message_type")]                                        
        public string Massege_type { get; set; } = string.Empty;        // Тип отправляемого сообщения (аренда, возврат, дней до возврата, дней просрочки)
        
        [Column("message_data")]
        public string MessageDataJson { get; set; } = "{}";             // Само сообщение

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;      // Дата создания

        [Column("status")]
        public string Status { get; set; } = "Pending";                 // Статус
        
        // Вспомогательные методы для работы с JSON
        [NotMapped]
        public T MessageData
        {
            get => JsonSerializer.Deserialize<T>(MessageDataJson ?? "{}");  // "ПРИ ЧТЕНИИ: взять строку MessageDataJson и преобразовать её в объект типа T"
                                                                            // "ЕСЛИ MessageDataJson равен null, то использовать '{}' (пустой JSON)"
            set => MessageDataJson = JsonSerializer.Serialize(value);       // "ПРИ ЗАПИСИ: взять объект value и преобразовать в JSON строку"
                                                                            // "записать результат в поле MessageDataJson"
        }
    }
}
