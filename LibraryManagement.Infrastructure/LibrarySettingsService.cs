
//Класс LibrarySettingsServece

using LibraryManagement.API;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILibrarySettingsServece
{
    public class LibrarySettingsServece : ILibrarySettingsServece
    {
        public LibrarySettingsServece Settings { get; }
        public LibrarySettingsServece(IConfiguration config) 
        {
            Settings = config.GetSection("LibrarySettings").Get<LibrarySettingsServece>();
        }
    }
}


public interface LibrarySettingsService
{
    LibrarySettings GetSettings(); // Метод для получения экземпляра класса настроек
}
