//Интерфейс

using LibraryManagement.Entities;

namespace LibraryManagement.Domain
{
    public interface ILibrarySettingsService
    {
        LibrarySettings Settings { get; }
    }
}