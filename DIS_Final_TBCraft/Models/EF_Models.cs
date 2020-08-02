using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DIS_Final_TBCraft.Models
{
    public class Beer
    {
        [Key]
        public int BeerId { get; set; }
        public string BeerName { get; set; }
        public string BeerType { get; set; }
        public string BeerABV { get; set; }
        public List<Ratings> Ratings { get; set; }
    }

    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserFName { get; set; }
        public string UserLName { get; set; }
        public string UserEmail { get; set; }
        public List<Ratings> Ratings { get; set; }
    }

    public class Ratings
    {
        public int RatingId { get; set; }
        public Beer Beer { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}