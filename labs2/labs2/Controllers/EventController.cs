using labs2.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace labs2.Controllers
{
    public class EventController : Controller
    {
        private static List<EventModel> events = new List<EventModel>();

        // GET: Index
        public ActionResult Index()
        {
            return View(events);
        }

        // GET: Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(string Ime, string Lokacija)
        {
            // VALIDATION: Lokacija length
            if (Lokacija == null || Lokacija.Length < 5 || Lokacija.Length > 30)
            {
                ViewBag.Error = "Lokacija must be between 5 and 30 characters.";
                return View();
            }

            int newId = 1;

            if (events.Count > 0)
            {
                int max = events[0].Id;

                for (int i = 1; i < events.Count; i++)
                {
                    if (events[i].Id > max)
                    {
                        max = events[i].Id;
                    }
                }

                newId = max + 1;
            }

            events.Add(new EventModel
            {
                Id = newId,
                Ime = Ime,
                Lokacija = Lokacija
            });

            return RedirectToAction("Index");
        }

        // POST: Delete
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            EventModel evToRemove = null;

            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Id == Id)
                {
                    evToRemove = events[i];
                    break;
                }
            }

            if (evToRemove != null)
            {
                events.Remove(evToRemove);
            }

            return RedirectToAction("Index");
        }

        // GET: Edit
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            EventModel ev = null;

            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Id == Id)
                {
                    ev = events[i];
                    break;
                }
            }

            if (ev == null)
            {
                return RedirectToAction("Index");
            }

            return View(ev);
        }

        // POST: Edit
        [HttpPost]
        public ActionResult Edit(int Id, string Ime, string Lokacija)
        {
            // VALIDATION: Lokacija length
            if (Lokacija == null || Lokacija.Length < 5 || Lokacija.Length > 30)
            {
                ViewBag.Error = "Lokacija must be between 5 and 30 characters.";
                return View();
            }

            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Id == Id)
                {
                    events[i].Ime = Ime;
                    events[i].Lokacija = Lokacija;
                    break;
                }
            }

            return RedirectToAction("Index");
        }

        // GET: Details
        [HttpGet]
        public ActionResult Details(int Id)
        {
            EventModel ev = null;

            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].Id == Id)
                {
                    ev = events[i];
                    break;
                }
            }

            if (ev == null)
                return RedirectToAction("Index");

            return View(ev);
        }

    }
}