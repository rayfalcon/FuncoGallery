using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using FuncoGallery.Models;
using FuncoGallery.ViewModels;

namespace FuncoGallery.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Games
        public ActionResult Index()
        {
            var games = _context.Games.ToList();

            return View("List", games);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new GameFormViewModel
            {
                Genres = genres
            };

            return View("GameForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Game games)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new GameFormViewModel(games)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("GameForm", viewModel);

            }
            if (games.Id == 0)
            {
                _context.Games.Add(games);

            }
            else
            {
                var gameInDb = _context.Games.Single(g => g.Id == games.Id);

                gameInDb.Name = games.Name;
                gameInDb.Price = games.Price;
                gameInDb.GenreId = games.GenreId;
                gameInDb.Quantity = games.Quantity;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Games");
        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            return View(game);
        }

        public ActionResult Edit(int Id)
        {
            var games = _context.Games.SingleOrDefault(g => g.Id == Id);

            if (games == null)
                return HttpNotFound();

            var viewModel = new GameFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View("GameForm", viewModel);


        }
    }
}