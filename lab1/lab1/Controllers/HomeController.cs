﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab1.Models;

namespace lab1.Controllers
{
    public class HomeController : Controller
    {
        Data dt = new Data();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SelectNotepad(string Name)
        {
            ViewBag.Name = Name;
            return View("Index");
        }

        public void CreateNotepad(string NoteName)
        {
           dt.AddNotepad(NoteName);
        }

        [HttpPost]
        public JsonResult LoadNotepads()
        {  
            return Json(dt.LoadNotes(), JsonRequestBehavior.AllowGet);
        }

        public string LoadContent(string NoteName)
        {
            return dt.GetContent(NoteName);
        }

        public void SetContent(string NoteName, string NoteContent)
        {
            dt.SetContent(NoteName, NoteContent);
        }

        public void CreateImage(string notepad)
        {
            dt.CreateImage(notepad);
        }

    }
}