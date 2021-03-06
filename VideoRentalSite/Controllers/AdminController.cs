﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VideoRentalSite.Models;

namespace VideoRentalSite.Controllers
{
    
    public class AdminController : Controller
    {
        private VideoRentalEntities db = new VideoRentalEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var item = db.video;
            return View(item);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            video video = db.video.Find(id);
            if (video == null)
            {
                return HttpNotFound();
            }
            return View(video);
        }

    }
}