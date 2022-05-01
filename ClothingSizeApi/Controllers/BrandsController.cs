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
    public async Task<ActionResult<IEnumerable<Brand>>> Get(string name, string gender, string clothingType, string xxxs, string xxs, string xs, string s, string m, string l, string xl, string xxl, string xxxl, string xxxxl)
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
        if (xxxs !=null)
      {
        query = query.Where(entry => entry.XXXS == xxxs);
      }   
  
      if (xxs !=null)
      {
        query = query.Where(entry => entry.XXS == xxs);
      }  

      if (xs !=null)
      {
        query = query.Where(entry => entry.XS == xs);
      }  
     if (s !=null)
      {
        query = query.Where(entry => entry.S == s);
      }  
     if (m !=null)
      {
        query = query.Where(entry => entry.M == m);
      } 
     if (l !=null)
      {
        query = query.Where(entry => entry.L == l);
      } 
     if (xl !=null)
      {
        query = query.Where(entry => entry.XL == xl);
      } 
     if (xxl !=null)
      {
        query = query.Where(entry => entry.XXL == xxl);
      } 
     if (xxxl !=null)
      {
        query = query.Where(entry => entry.XXXL == xxxl);
      } 
      if (xxxxl !=null)
      {
        query = query.Where(entry => entry.XXXXL == xxxxl);
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

    // GET: api/Brands/gap/
    [HttpGet("/{name}")]
    public async Task<ActionResult<IEnumerable<Brand>>> GetName(string name)
    {
      var query = _db.Brands.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      return await query.ToListAsync();
    }

    // GET: api/Brands/
     [HttpGet("/brands/")]
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