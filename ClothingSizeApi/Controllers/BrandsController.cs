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
    public async Task<ActionResult<IEnumerable<Brand>>> Get()
    {
      return await _db.Brands.ToListAsync();
      
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

    // GET: api/Brands/Name/
    [HttpGet("/Name")]
    public async Task<ActionResult<IEnumerable<Brand>>> GetName(string name)
    {
      var query = _db.Brands.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return await query.ToListAsync();
    }

    // GET: api/Brands/size/
    [HttpGet("/size")]
    public async Task<ActionResult<IEnumerable<Brand>>> GetSize(string size)
    {
      var query = _db.Brands.AsQueryable();

     switch (size)
     {
        case "xxxs":
          query = query.Where(entry => entry.XXXS == size);
          break;
        case "xxs":
          query = query.Where(entry => entry.XXS == size);
          break;
        case "xs":
          query = query.Where(entry => entry.XS == size);
          break;
        case "s":
          query = query.Where(entry => entry.S == size);
          break;
        case "M":
          query = query.Where(entry => entry.M == size);
          break;
        case "L":
          query = query.Where(entry => entry.L == size);
          break;
        case "XL":
          query = query.Where(entry => entry.XL == size);
          break;
        case "XXL":
          query = query.Where(entry => entry.XXL == size);
          break;
        case "XXXL":
          query = query.Where(entry => entry.XXXL == size);
          break;
        case "XXXXL":
          query = query.Where(entry => entry.XXXXL == size);
          break;
     }


      return await query.ToListAsync();
    }
    
  }
}