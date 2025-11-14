//Класс Book.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Domain.Entities
{
    public enum Age_restriction
    // Возрастные ограничения
    {
        G = 0,      // Для всех возрастов
        PG = 7,     // С 7 лет
        PG13 = 13,  // С 13 лет
        R = 17,     // С 17 лет
        NC17 = 18   // С 18 лет
    }
    // Использование в модели
    /*
    public class Book
    {
        public string Title { get; set; }
        public AgeRating Rating { get; set; }
    }
    */

    [Table("Book")]
    public class Book
    {
        [Key]
        [Column("book_id")]
        public uint Book_id { get; set; }                       // Идентификатор книги
        
        [ForeignKey("Author")]
        [Column("author_id")]
        public int Author_id { get; set; }                      // Идентификатор автора
        
        [Column("title")]
        public string Title { get; set; } = string.Empty;       // Наименование
        
        [Column("age_restriction")]
        public Age_restriction Age_restriction { get; set; }


        [Column("daily_fine_rate")]
        public uint Daily_fine_rate { get; set; }                  // Дневная ставка штрафа
    }
}

// Для AgeRestriction (Возрастного ограничения) можно создать одельный класс
/*
public class AgeRestriction
{
    public AgeRating Type { get; set; }     // enum для логики
    public string DisplayName { get; set; } // "18+", "Для взрослых"
    public byte MinAge { get; set; }        // 18 для расчетов

    // Метод проверки
    public bool IsAllowed(int userAge) => userAge >= MinAge;
}

// Использование в контроллере
[ApiController]
public class MovieController : ControllerBase
{
    [HttpPost]
    public IActionResult CheckAccess([FromBody] CheckAccessRequest request)
    {
        var movie = _movieService.GetMovie(request.MovieId);
        var hasAccess = movie.AgeRestriction.IsAllowed(request.UserAge);

        return Ok(new { HasAccess = hasAccess });
    }
}
*/


// Практический пример в контроллере
/*
[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    [HttpGet("check-access/{movieId}/{userAge}")]
    public IActionResult CheckAccess(int movieId, int userAge)
    {
        var movie = _movies.FirstOrDefault(m => m.Id == movieId);
        if (movie == null) return NotFound();
        
        // Простая проверка
        if (userAge < (int)movie.Rating)
        {
            return Ok(new { 
                Access = false, 
                Message = $"Контент доступен с {movie.Rating} лет" 
            });
        }
        
        return Ok(new { Access = true });
    }
    
    // Пример данных
    private List<Movie> _movies = new()
    {
        new Movie { Id = 1, Title = "Мультфильм", Rating = AgeRating.G },
        new Movie { Id = 2, Title = "Приключения", Rating = AgeRating.PG },
        new Movie { Id = 3, Title = "Триллер", Rating = AgeRating.PG13 },
        new Movie { Id = 4, Title = "Для взрослых", Rating = AgeRating.R }
    };
}
*/