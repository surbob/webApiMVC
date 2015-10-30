﻿using System;
using System.Collections.Generic;
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
            of.Coupen_Code = "ABC";
            of.Offer_Image1_Path = "a";
            of.Offer_image2_Path = "a";
            of.Offer_Title = "10% off with sbi credit";
            of.Offer_Link = "d";
            ofr.Add(of);
            offer of2 = new offer();
            of2.offerID = 1;
            of2.Available_On = 'S';
            of2.Coupen_Code = "ABC";
            of2.Offer_Image1_Path = "paytmpath";
            of2.Offer_image2_Path = "a";
            of2.Offer_Title = "50% off on offer";
            of2.Offer_Link = "www.google.com";
            ofr.Add(of2);
            return ofr;
        }
    }
}
