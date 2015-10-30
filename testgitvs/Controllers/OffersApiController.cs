using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using testgitvs.Models;

namespace testgitvs.Controllers
{
    public class OffersApiController : ApiController
    {

        // GET api/values
        public List<offer> GetOffers()
        {
            List<offer> ofr = new List<offer>();
            offer of = new offer();
            of.offerID = 1;
            of.Available_On = 'O';
            of.Coupen_Code = "OCT50";
            of.Offer_Image1_Path = "http://placehold.it/50x50&text=img1";
            of.Offer_image2_Path = "http://placehold.it/120x120&text=img1"; ;
            of.Offer_Title = "10% off with sbi credit";
            of.Offer_Link = "d";
            of.moreDescription = "recharge your mobile with paytm and get 50% cash back";
            ofr.Add(of);
            offer of2 = new offer();
            of2.offerID = 1;
            of2.Available_On = 'S';
            of2.Coupen_Code = "OCT10";
            of2.Offer_Image1_Path = "http://placehold.it/50x50&text=img2";
            of2.Offer_image2_Path = "http://placehold.it/120x120&text=img2";
            of2.Offer_Title = "50% off on offer";
            of2.Offer_Link = "www.google.com";
            of2.moreDescription = "book  your bus ticket with redbus and get 20% cash back";
            ofr.Add(of2);
            return ofr;



            //SqlConnection conn = null;
            //SqlDataReader rdr = null;

            //Console.WriteLine("\nTop 10 Most Expensive Products:\n");

            //try
            //{
            //    conn = new SqlConnection("Server=(local);DataBase=master;Integrated Security=SSPI");
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("dbo.test", conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    rdr = cmd.ExecuteReader();
            //    /*while (rdr.Read())
            //    {
            //        Console.WriteLine(
            //            "Product: {0,-25} Price: ${1,6:####.00}",
            //            rdr["TenMostExpensiveProducts"],
            //            rdr["UnitPrice"]);
            //    }*/
            //}
            //finally
            //{
            //    if (conn != null)
            //    {
            //        conn.Close();
            //    }
            //    if (rdr != null)
            //    {
            //        rdr.Close();
            //    }
            //}
        }
    }
}
