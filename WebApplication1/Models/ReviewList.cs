using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ReviewList
    {
        private static List<Review> reviews = new List<Review>()
        {
            new Review {ID=1, ReviewParam="Loved this song"},
            new Review {ID=2, ReviewParam="Hated this song"},
            new Review {ID=3, ReviewParam="Heard better, heard worse"}
        };

        public static void AddReview(Review newReview)
        {
            reviews.Add(newReview);
        }

        public static List<Review> GetAllReviews()
        {
            return reviews;
        }

        public static Review GetAReview(int id)
        {
            Review r = new Review();
            foreach (Review s in reviews)
                if (s.ID == id)
                    r = s;
            return r;
        }

        public static bool Update(int id, Review UpdateReview)
        {
            bool returnValue = false;

            foreach (Review s in reviews)
                if (s.ID == id)
                {
                    s.ReviewParam = UpdateReview.ReviewParam;
                    returnValue = true;
                }
            return returnValue;
        }

        public static void DeleteReview(int id)
        {
            reviews.Remove(reviews.Find(x => x.ID == id));
        }

    }
}