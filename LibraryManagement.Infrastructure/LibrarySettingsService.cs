using Microsoft.Extensions.Configuration;
using LibraryManagement.Domain.Interfaces;

namespace LibraryManagement.Infrastructure.Services
{
    public class LibrarySettingsService : ILibrarySettingsService
    {
        private readonly IConfiguration _configuration;

        public LibrarySettingsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetLibraryName() => _configuration["LibrarySettings:LibraryName"];
        public int GetDefaultLoanDays() => int.Parse(_configuration["LibrarySettings:DefaultLoanDays"]);
        public decimal GetDailyFineRate() => decimal.Parse(_configuration["LibrarySettings:DailyFineRate"]);
    }
}