//Класс Author.

namespace LibraryManagement.Domain.Entities
//namespace LibraryManagement.Domain.LibraryManagement.Domain
{
    public class Author
    {
        public int Id { get; set; }                            //Идентификатор
        public string FullName { get; set; } = string.Empty;    //Полное имя (ФИО)
        public string Country { get; set; } = string.Empty;     //Страна
        public string Email { get; set; } = string.Empty;       //Электронная почта
    }
}