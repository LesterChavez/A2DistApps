using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ReviewsController : ApiController
    {
        // GET: api/Reviews
        public IEnumerable<Review> Get()
        {
            return ReviewList.GetAllReviews();
        }

        // GET: api/Reviews/5
        public Review Get(int id)
        {
            return ReviewList.GetAReview(id);
        }

        // POST: api/Reviews
        public Review Post(Review value)
        {
            ReviewList.AddReview(value);
            return ReviewList.GetAReview(value.ID);
        }

        // PUT: api/Reviews/5
        public void Put(int id,Review value)
        {
            ReviewList.Update(id, value);
        }

        // DELETE: api/Reviews/5
        public void Delete(int id)
        {
            ReviewList.DeleteReview(id);
        }
    }
}
