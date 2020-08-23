using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DIS_Final_TBCraft.DataAccess;
using DIS_Final_TBCraft.Models;

namespace DIS_Final_TBCraft.Controllers
{
    public class DatabaseExampleController : Controller
    {
        public ApplicationDbContext dbContext;

        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ViewResult> DatabaseOperations()
        {
            //CREATE tables
            Models.Beer Beer1 = new Models.Beer();
            Beer1.BeerId   =  1;
            Beer1.BeerName = "Cigar City Jai Alai";
            Beer1.BeerType = "IPA";
            Beer1.BeerABV  = "6.7%";

            Models.Beer Beer2 = new Models.Beer();
            Beer2.BeerId = 2;
            Beer2.BeerName = "Coppertail Free Dive";
            Beer2.BeerType = "IPA";
            Beer2.BeerABV  = "6.4%";

            Models.Beer Beer3 = new Models.Beer();
            Beer3.BeerId =  3;
            Beer3.BeerName = "Reef Donkey";
            Beer3.BeerType = "IPA";
            Beer3.BeerABV  = "6.3%";

            User User1 = new User();
            User1.UserId = 1;
            User1.UserFName = "Raquel";
            User1.UserLName = "Pavlik";
            User1.UserEmail = "raquelvanessa@usf.edu";

            User User2 = new User();
            User2.UserId = 2;
            User2.UserFName = "Austin";
            User2.UserLName = "Johnson";
            User2.UserEmail = "austindjohnson@usf.edu";

            User User3 = new User();
            User3.UserId = 3;
            User3.UserFName = "Shawn";
            User3.UserLName = "McGinty";
            User3.UserEmail = "smginty@usf.edu";

            User User4 = new User();
            User4.UserId = 4;
            User4.UserFName = "Guest";
            User4.UserLName = "User";
            User4.UserEmail = "NULL";

            //Ratings
            Ratings Rating1 = new Ratings();
            Rating1.RatingId = 100;
            Rating1.Beer = Beer1;
            Rating1.User = User1;
            Rating1.Rating = 5;
            Rating1.Comment = "Too hoppy";

            Ratings Rating2 = new Ratings();
            Rating2.RatingId = 101;
            Rating2.Beer = Beer1;
            Rating2.User = User2;
            Rating2.Rating = 4;
            Rating2.Comment = "Too strong";

            Ratings Rating3 = new Ratings();
            Rating3.RatingId = 103;
            Rating3.Beer = Beer1;
            Rating3.User = User3;
            Rating3.Rating = 9;
            Rating3.Comment = "Almost perfect";

            Ratings Rating4 = new Ratings();
            Rating4.RatingId = 104;
            Rating4.Beer = Beer2;
            Rating4.User = User1;
            Rating4.Rating = 7;
            Rating4.Comment = "Very good";

            Ratings Rating5 = new Ratings();
            Rating5.RatingId = 105;
            Rating5.Beer = Beer2;
            Rating5.User = User2;
            Rating5.Rating = 2;
            Rating5.Comment = "Did not like";

            Ratings Rating6 = new Ratings();
            Rating6.RatingId = 106;
            Rating6.Beer = Beer2;
            Rating6.User = User3;
            Rating6.Rating = 10;
            Rating6.Comment = "Perfect";

            Ratings Rating7 = new Ratings();
            Rating7.RatingId = 107;
            Rating7.Beer = Beer3;
            Rating7.User = User1;
            Rating7.Rating = 10;
            Rating7.Comment = "Perfect";

            Ratings Rating8 = new Ratings();
            Rating8.RatingId = 108;
            Rating8.Beer = Beer3;
            Rating8.User = User2;
            Rating8.Rating = 6;
            Rating8.Comment = "Ok";

            Ratings Rating9 = new Ratings();
            Rating9.RatingId = 109;
            Rating9.Beer = Beer3;
            Rating9.User = User3;
            Rating9.Rating = 5;
            Rating9.Comment = "Mediocre";


            return View();
        }
    }
}  