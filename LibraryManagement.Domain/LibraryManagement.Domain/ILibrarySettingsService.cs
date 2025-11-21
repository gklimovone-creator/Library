//Интерфейс

namespace LibraryManagement.Domain.Interfaces
{
    public interface ILibrarySettingsService
    {
        string GetLibraryName();
        int GetDefaultLoanDays();
        decimal GetDailyFineRate();
    }
}