//Класс appsettings.json.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.LibraryManagement.Domain.Entities
{
    public class LibrarySettings
    {
        public string LibraryName { get; set; }
        public int DefaultLoanDays { get; set; }
        public decimal DailyFineRate { get; set; }
        public int ReminderDaysBeforeEnd { get; set; }
        public int MaxBooksPerUser { get; set; }
    }
}
