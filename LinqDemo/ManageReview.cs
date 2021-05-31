using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
   public class ManageReview
   {
         public  ArrayList GetTop3HighestRatedRecords(List<ProductReview> reviewList)
         {
            ArrayList outputList = new ArrayList();
            var highestRatedRows = (from rec in reviewList
                                    orderby rec.rating descending
                                    select rec).Take(3);
            foreach (var row in highestRatedRows)
            {
                Console.WriteLine(row.ToString());
                outputList.Add(row.ToString());
            }

            return outputList;

         }
         public ArrayList RatingGreaterThan3(List<ProductReview> reviewList)
         {
            ArrayList outputList = new ArrayList();

            var records = (from rec in reviewList
                           where rec.rating > 3 && (rec.productId == 1 || rec.productId == 3 || rec.productId == 9)
                           select rec);
            foreach (var row in records)
            {
                Console.WriteLine(row.ToString());
                outputList.Add(row.ToString());
            }
            return outputList;
         }

         public ArrayList CountforeachProductId(List<ProductReview> reviewList)
         {
            ArrayList outputList = new ArrayList();
            var records = (from rec in reviewList
                           group rec by rec.productId into g
                           select new
                           {
                               productId2 = g.Key,
                               ReviewCount = g.Count()
                           });
            foreach (var row in records)
            {
                Console.WriteLine(row.ToString());
                outputList.Add(row.ToString());
            }
            return outputList;
         }
        public ArrayList RetrieveProductIdAndReview(List<ProductReview> reviewList)
        {
            ArrayList outputList = new ArrayList();
            var records = (from rec in reviewList
                           select new { rec.productId, rec.review });
            foreach(var element in records)
            {
                Console.WriteLine(element.ToString());
                outputList.Add(element.ToString());
            }
            return outputList;
        }
        public ArrayList SkipTop5Records(List<ProductReview> reviewList)
        {
            ArrayList outputList = new ArrayList();
            var records = (from rec in reviewList
                          orderby rec.rating descending
                          select rec);
            foreach(var element in records.Skip(5))
            {
                Console.WriteLine(element.ToString());
                outputList.Add(element.ToString());
            }
            return outputList;
        }
        
   }
}
