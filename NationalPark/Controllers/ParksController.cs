using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalPark.Models;

namespace NationalPark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private NationalParkContext _db;

    public ParksController(NationalParkContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public ActionResult<IEnumerable<Park>> Get()
    {
      return _db.Parks.ToList();
    }

    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
  }
}