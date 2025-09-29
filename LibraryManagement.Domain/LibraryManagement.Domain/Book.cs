//Класс Book.

namespace LibraryManagement.Domain.Entities
//namespace LibraryManagement.Domain.LibraryManagement.Domain
{
    public class Book
    {
        public uint ID;                                         // Идентификатор
        public string Title { get; set; } = string.Empty;       // Наименование
        public enum AgeRestriction                              // Возрастные ограничения
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
        public uint StandardLoanDurationInDays { get; set; }     // Стандартный срок выдачи книг (в днях)
        public uint DailyFineRate { get; set; }                  // Дневная ставка штрафа
        public uint AuthorId { get; set; }                       // Идентификатор автора
        public string Author { get; set; } = string.Empty;       // Автор
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