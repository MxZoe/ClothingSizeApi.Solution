using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClothingSizeApi.Models;

namespace ClothingSizeApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BrandsController : ControllerBase
  {
    private readonly ClothingSizeApiContext _db;

    public BrandsController(ClothingSizeApiContext db)
    {
      _db = db;
    }

    // GET: api/Brands/
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Brand>>> Get(string name, string gender, string clothingType)
    {
      var query = _db.Brands.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (clothingType != null)
      {
        query = query.Where(entry => entry.ClothingType == clothingType);
      }    
      return await query.ToListAsync();
      
    }

    // GET: api/Brands/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Brand>> GetBrand(int id)
    {
        var brand = await _db.Brands.FindAsync(id);

        if (brand == null)
        {
            return NotFound();
        }

        return brand;
    }


    // PUT: api/Brands/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Brand brand)
    {
      if (id != brand.BrandId)
      {
        return BadRequest();
      }

      _db.Entry(brand).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BrandExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/Brands
    [HttpPost]
    public async Task<ActionResult<Brand>> Post(Brand brand)
    {
      _db.Brands.Add(brand);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBrand), new { id = brand.BrandId }, brand);
    }

    // DELETE: api/Brands/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBrand(int id)
    {
      var brand = await _db.Brands.FindAsync(id);
      if (brand == null)
      {
        return NotFound();
      }

      _db.Brands.Remove(brand);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool BrandExists(int id)
    {
      return _db.Brands.Any(e => e.BrandId == id);
    }
    
  }
}