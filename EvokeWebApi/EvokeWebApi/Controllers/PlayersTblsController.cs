//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using EvokeWebApi.Models;

//namespace EvokeWebApi.Controllers
//{
//    [ApiController]
//    [Route("[controller]/[action]")]
//    public class PlayersTblsController : Controller
//    {
//        private readonly PlayersContext _context;


//        public PlayersTblsController(PlayersContext context)
//        {
//            _context = context;
//        }

//        // GET: PlayersTbls
//        public async Task<IActionResult> Index()
//        {
//            return _context.PlayersTbls != null ?
//                        View(await _context.PlayersTbls.ToListAsync()) :
//                        Problem("Entity set 'PlayersContext.PlayersTbls'  is null.");
//        }

//        // GET: PlayersTbls/Details/5
//        //public async Task<IActionResult> Details(int? id)
//        //{
//        //    if (id == null || _context.PlayersTbls == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var playersTbl = await _context.PlayersTbls
//        //        .FirstOrDefaultAsync(m => m.Id == id);
//        //    if (playersTbl == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(playersTbl);
//        //}

//        // GET: PlayersTbls/Create
//        //public IActionResult Create()
//        //{
//        //    return View();
//        //}

//        // POST: PlayersTbls/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,Name,Countryorigin,Skilled,Achievement")] PlayersTbl playersTbl)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(playersTbl);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(playersTbl);
//        }

//        // GET: PlayersTbls/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.PlayersTbls == null)
//            {
//                return NotFound();
//            }

//            var playersTbl = await _context.PlayersTbls.FindAsync(id);
//            if (playersTbl == null)
//            {
//                return NotFound();
//            }
//            return View(playersTbl);
//        }

//        // POST: PlayersTbls/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Countryorigin,Skilled,Achievement")] PlayersTbl playersTbl)
//        {
//            if (id != playersTbl.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(playersTbl);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!PlayersTblExists(playersTbl.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(playersTbl);
//        }

//        // GET: PlayersTbls/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.PlayersTbls == null)
//            {
//                return NotFound();
//            }

//            var playersTbl = await _context.PlayersTbls
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (playersTbl == null)
//            {
//                return NotFound();
//            }

//            return View(playersTbl);
//        }

//        // POST: PlayersTbls/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.PlayersTbls == null)
//            {
//                return Problem("Entity set 'PlayersContext.PlayersTbls'  is null.");
//            }
//            var playersTbl = await _context.PlayersTbls.FindAsync(id);
//            if (playersTbl != null)
//            {
//                _context.PlayersTbls.Remove(playersTbl);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool PlayersTblExists(int id)
//        {
//            return (_context.PlayersTbls?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EvokeWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EvokeWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PlayersTblsController : ControllerBase
    {
        static List<PlayersTbl> Players = new List<PlayersTbl>();
        PlayersContext context = new PlayersContext();
        private readonly ILogger<PlayersTblsController> _logger;
     

        public PlayersTblsController(ILogger<PlayersTblsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(template: "GetPlayers")]
        public IEnumerable<PlayersTbl> Get()
        {
            return context.PlayersTbls.ToList();
        }

        [HttpPost]

        public IActionResult Post([FromBody] PlayersTbl players)
        {
            if (players == null)
            {
                return BadRequest();
            }
            try
            {
                context.Add(players);
                context.SaveChanges();
                return Ok(context.PlayersTbls.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPut]
        public IActionResult Put(PlayersTbl players)
        {
            if (players == null) { 
            return BadRequest();}


            if ((context.PlayersTbls?.Any(e => e.Id == players.Id)).GetValueOrDefault())
            {
                context.Update(players);
                context.SaveChanges();
                return Ok(context.PlayersTbls.ToList());
            }
            else
            {
                return NotFound("Player does not exist");
            }
        }
        //[HttpPut]
        //public IActionResult Put(PlayersTbl players)
        //{
        //    if (Players.ToList().Count > 0)
        //    {
        //        int index = Pl.FindIndex(n => n.Equals(name));
        //        names[index] = newName;
        //    }
        //    else
        //    {
        //        return BadRequest("Name is Empty");
        //    }
        //    return Ok();


        //}
        //[HttpDelete]
        //public IActionResult Delete(string name)
        //{
        //    if (names.Count > 0)
        //    {
        //        int index = names.FindIndex(n => n.Equals(name));
        //        if (index >= 0)
        //        {
        //            names.Remove(name);
        //            return Ok("Record Deleted");
        //        }
        //    }
        //    return NotFound("Name doesn't exist in collection");
        //    //return NoContent();


        //}
    }
}