using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Data;

namespace WebLinqExercises.Pages
{
    public class QuestionModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public QuestionModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string id)
        {
            if (id == "1")
            {
                //  //1. Visa alla filmer som släpptes någon gång under 90-talet.
                ViewData["data"] = Data
                                    .Repository
                                    
                                    .GetAllMovies()
                                    // TODO Add Where 
                                    .ToList()
                                    .ToHtmlTable();
            }
            else if (id == "2")
            {
                //Visa alla filmer vars Actor-lista innehåller tre skådespelare  (tips: för detta kan du behöva använda metoden Count)

                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Where 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "3")
            {
                /// Visa alla filmer som där någon av skådespelarna i filmen var äldre än 40 år när filmen gjordes
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Where 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "4")
            {
                //Visa alla skådespelare som är äldre än 50 år. Sortera skådespelarna på namn.
                ViewData["data"] = Data.Repository
                .GetAllActors()
                // TODO Add Where och order 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "5")
            {
                //Visa alla skådespelare som har bokstaven "g" eller ”G” i sitt namn. Det skall inte spela

                ViewData["data"] = Data.Repository
                .GetAllActors()
                // TODO Add Where 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "6")
            {
                //Visa för alla skådespelare bara deras namn och ålder.
                ViewData["data"] = Data.Repository
                .GetAllActors()
                // TODO Add Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "7")
            {
                //Visa en lista innehållande filmtitel, regissör och antal skådespelare för alla filmer.

                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "8")
            {
                //Visa för alla filmer filmens titel, samt genomsnittliga åldern för skådespelarna i filmen

                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "9")
            {
                //ta fram alla filmer som gjordes under 2000-talet och där regissören heter Martin
                //Scorsese.Visa bara Titel, release år och regissör.
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add where Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "10")
            {
                // Visa alla skådespelare som är med i mer än en film. Visa också hur många filmer de är med i.

                ViewData["data"] = Data.Repository
                .GetAllActors()
  // TODO Add where Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "11")
            {
                // visa alla filmer vars årtal är senare än det genomsnittliga årtalet för alla filmer.Sortera resultatet på årtalet i stigande ordning(ascending).

                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Where + order 
                .ToList()
                .ToHtmlTable();
           }

        }
    }
}