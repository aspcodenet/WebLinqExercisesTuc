﻿using Microsoft.AspNetCore.Mvc;
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
                ViewData["data"] = Data
                                    .Repository
                                    
                                    .GetAllMovies()
                                    // TODO Add Where 
                                    .ToList()
                                    .ToHtmlTable();
            }
            else if (id == "2")
            {
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Where 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "3")
            {
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Where 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "4")
            {
                ViewData["data"] = Data.Repository
                .GetAllActors()
                // TODO Add Where och order 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "5")
            {
                ViewData["data"] = Data.Repository
                .GetAllActors()
                // TODO Add Where 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "6")
            {
                ViewData["data"] = Data.Repository
                .GetAllActors()
                // TODO Add Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "7")
            {
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "8")
            {
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "9")
            {
                ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add where Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "10")
            {
                ViewData["data"] = Data.Repository
                .GetAllActors()
  // TODO Add where Select 
                .ToList()
                .ToHtmlTable();
            }
            else if (id == "11")
            {
                 ViewData["data"] = Data.Repository
                .GetAllMovies()
                // TODO Add Where + order 
                .ToList()
                .ToHtmlTable();
           }

        }
    }
}