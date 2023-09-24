using Library.DataContext;
using Library.Models.Entities;
using Library.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        readonly LibraryDbContext _context;
        public AuthorController(LibraryDbContext context)
        {
            _context = context;
        }
        // GET: AuthorController
        public ActionResult Index()
        {
            List<Author> authors = _context.Authors.Include(a => a.Country).ToList();
            return View(authors);
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author author = _context.Authors.Include(a => a.Country).SingleOrDefault(a => a.Id == id);
            return View(author);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            AuthorVM authorVM = new AuthorVM
            {
                Countries = _context.Countries.ToList(),
                CountryList = new List<SelectListItem>()
            };

            foreach(var country in authorVM.Countries)
            {
                authorVM.CountryList.AddRange(new List<SelectListItem>()
                {
                    new SelectListItem(){ Text = country.FullName, Value = country.Id.ToString() }
                });
            }

            return View(authorVM);
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author author)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    _context.Authors.Add(author);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            AuthorVM authorVM = new AuthorVM
            {
                Author = _context.Authors.Include(a => a.Country).SingleOrDefault(a => a.Id == id),
                Countries = _context.Countries.ToList(),
                CountryList = new List<SelectListItem>()
            };

            foreach (var country in authorVM.Countries)
            {
                authorVM.CountryList.AddRange(new List<SelectListItem>
                {
                    new SelectListItem () { Text = country.FullName,Value = country.Id.ToString()}
                });
            }

            return View(authorVM);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Author author)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Authors.Update(author);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {

            Author author = _context.Authors.Include(a => a.Country).SingleOrDefault(a => a.Id == id);
            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Author author)
        {
            try
            {
                if (_context.Authors.Contains(author))
                {
                    _context.Authors.Remove(author);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
