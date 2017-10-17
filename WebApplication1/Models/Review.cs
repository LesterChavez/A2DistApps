using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Review
    {
        private int id;
        private string review;


        public Review()
        {

        }
        public Review(int ID, string reviewPeram)
        {
            id = ID;
            review = reviewPeram;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ReviewParam
        {
            get { return review; }
            set { review = value; }
        }
    }

}