using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {

        private readonly AppDbContext _context;

        // kur don mu thirr psh / ActorsController kjo vjen nga 
        //IActionResult Index


        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
