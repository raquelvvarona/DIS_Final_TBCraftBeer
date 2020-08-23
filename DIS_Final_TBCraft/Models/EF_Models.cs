using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DIS_Final_TBCraft.Models;

namespace DIS_Final_TBCraft.Models
{


    public class Breweryapis
    {
        public Breweryapi[] data { get; set; }
    }

    public class Breweryapi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brewery_type { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal_code { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Phone { get; set; }
        public string Website_url { get; set; }
        public string Updated_at { get; set; }
    }
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
        [Key]
        public int RatingId { get; set; }
        public Beer Beer { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}