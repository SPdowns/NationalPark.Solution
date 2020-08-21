using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public ActionResult<IEnumerable<Park>> Get(string name, string location, string description, string dateestablished, string image)
    {
      var query = _db.Parks.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
      if (dateestablished != null)
      {
        query = query.Where(entry => entry.DateEstablished == dateestablished);
      }
      if (image != null)
      {
        query = query.Where(entry => entry.Image == image);
      }
    }
    // POST api/parks
    [HttpPost]
    public void Post([FromBody] Park park)
    {
      _db.Parks.Add(park);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Park> Get(int id)
    {
        return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
    }
    // PUT api/parks/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Park park)
    {
        park.ParkId = id;
        _db.Entry(park).State = EntityState.Modified;
        _db.SaveChanges();
    }
    // DELETE api/parks/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
      _db.Parks.Remove(parkToDelete);
      _db.SaveChanges();
    }
  }
}