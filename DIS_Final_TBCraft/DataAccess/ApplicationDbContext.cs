using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DIS_Final_TBCraft.DataAccess
{
    public class ApplicationDbContext
    {

        public class Beer
        {
            public int BeerId { get; set; }
            public string BeerName { get; set; }
            public string BeerType { get; set; }
            public string BeerABV { get; set; }
            public List<Ratings> Ratings { get; set; }
        }

        public class User
        {
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
}
