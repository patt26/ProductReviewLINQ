using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1

            List<ProductReview> reviewList = new List<ProductReview>();
            {
                reviewList.Add(new ProductReview() { productId = 1, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 1, userId = 2, rating = 3, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 1, userId = 3, rating = 4, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 1, userId = 4, rating = 3, isLike = "Yes", review = "Nice" });
                reviewList.Add(new ProductReview() { productId = 1, userId = 5, rating = 4, isLike = "Yes", review = "Good" });
                reviewList.Add(new ProductReview() { productId = 2, userId = 1, rating = 1, isLike = "No", review = "Unsatifactory" });
                reviewList.Add(new ProductReview() { productId = 2, userId = 2, rating = 3, isLike = "Yes", review = "Good" });
                reviewList.Add(new ProductReview() { productId = 2, userId = 3, rating = 4, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 2, userId = 4, rating = 3, isLike = "Yes", review = "Nice" });
                reviewList.Add(new ProductReview() { productId = 2, userId = 5, rating = 4, isLike = "Yes", review = "Good" });
                reviewList.Add(new ProductReview() { productId = 3, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 3, userId = 2, rating = 3, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 3, userId = 3, rating = 4, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 3, userId = 4, rating = 3, isLike = "Yes", review = "Nice" });
                reviewList.Add(new ProductReview() { productId = 3, userId = 5, rating = 4, isLike = "Yes", review = "Good" });
                reviewList.Add(new ProductReview() { productId = 4, userId = 1, rating = 1, isLike = "No", review = "Unsatifactory" });
                reviewList.Add(new ProductReview() { productId = 4, userId = 2, rating = 2, isLike = "No", review = "Bad" });
                reviewList.Add(new ProductReview() { productId = 4, userId = 3, rating = 2, isLike = "No", review = "Worst" });
                reviewList.Add(new ProductReview() { productId = 4, userId = 4, rating = 3, isLike = "No", review = "Not good" });
                reviewList.Add(new ProductReview() { productId = 4, userId = 5, rating = 2, isLike = "No", review = "Okay" });
                reviewList.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 5, userId = 1, rating = 5, isLike = "Yes", review = "Awesome" });
                reviewList.Add(new ProductReview() { productId = 9, userId = 1, rating = 5, isLike = "Yes", review = "Does the work" });
            }
            
            ManageReview review = new ManageReview();

            ////UC2 
            //review.GetTop3HighestRatedRecords(reviewList);

            ////UC3
            //review.RatingGreaterThan3(reviewList);

            ////UC4
            //review.CountforeachProductId(reviewList);

            ////UC5
            //review.RetrieveProductIdAndReview(reviewList);

            //UC6
            review.SkipTop5Records(reviewList);








        }

    }
}
