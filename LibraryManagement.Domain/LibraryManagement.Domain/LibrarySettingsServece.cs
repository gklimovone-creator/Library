//Класс LibrarySettingsServece

using LibraryManagement.API;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySettingsServece
{
    public interface ILibrarySettingsServece
    {
        LibrarySettings Settings { get; }
    }
}