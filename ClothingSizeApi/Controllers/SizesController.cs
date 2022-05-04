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
  public class SizesController : ControllerBase
  {
    private readonly ClothingSizeApiContext _db;

    public SizesController(ClothingSizeApiContext db)
    {
      _db = db;
    }

    // GET: api/Sizes/
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Size>>> Get(string letterSize, string gender, string clothingType, int neck, int chest, int sleeve,  int waist,  int hip, int inseam)
    {
      var query = _db.Sizes.AsQueryable();

      if (clothingType != null)
      {
        query = query.Where(entry => entry.ClothingType == clothingType);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (letterSize != null)
      {
        query = query.Where(entry => entry.LetterSize == letterSize);
      }    
        if (neck > 0)
      {
        query = query.Where(entry => entry.Neck == neck);
      }   
  
      if (chest > 0)
      {
        query = query.Where(entry => entry.Chest == chest);
      }  

      if (sleeve > 0)
      {
        query = query.Where(entry => entry.Sleeve == sleeve);
      }  
      if (waist > 0 )
      {
        query = query.Where(entry => entry.Waist == waist);
      }  
      if (hip > 0)
      {
        query = query.Where(entry => entry.Hip == hip);
      } 
      if (inseam > 0 )
      {
        query = query.Where(entry => entry.Inseam == inseam);
      } 
    
      return await query.ToListAsync();
      
    }

    // GET: api/Sizes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Size>> GetSize(int id)
    {
        var size = await _db.Sizes.FindAsync(id);

        if (size == null)
        {
            return NotFound();
        }

        return size;
    }


    // PUT: api/Sizes/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Size size)
    {
      if (id != size.SizeId)
      {
        return BadRequest();
      }

      _db.Entry(size).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!SizeExists(id))
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

    // POST: api/Sizes
    [HttpPost]
    public async Task<ActionResult<Size>> Post(Size size)
    {
      _db.Sizes.Add(size);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetSize), new { id = size.SizeId }, size);
    }

    // DELETE: api/Sizes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSize(int id)
    {
      var size = await _db.Sizes.FindAsync(id);
      if (size == null)
      {
        return NotFound();
      }

      _db.Sizes.Remove(size);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool SizeExists(int id)
    {
      return _db.Sizes.Any(e => e.SizeId == id);
    }

    // // GET: api/Sizes/bottoms/
    // [HttpGet("{clothingType}")]
    // public async Task<ActionResult<IEnumerable<Size>>> GetClothingType(string clothingType)
    // {
    //   var query = _db.Sizes.AsQueryable();

    //   if (clothingType != null)
    //   {
    //     query = query.Where(entry => entry.ClothingType == clothingType);
    //   }

    //   return await query.ToListAsync();
    // }





    

    // // GET: api/Sizes/
    //  [HttpGet("/Sizes/")]
    //  public async Task<ActionResult<IEnumerable<Size>>> GetSize(int size)
    //  {
    //    var query = _db.Sizes.AsQueryable();

    //   switch (size)
    //   {
    //      case "xxxs":
    //        query = query.Where(entry => entry.XXXS == size);
    //        break;
    //      case "xxs":
    //        query = query.Where(entry => entry.XXS == size);
    //        break;
    //      case "xs":
    //        query = query.Where(entry => entry.XS == size);
    //        break;
    //      case "s":
    //        query = query.Where(entry => entry.S == size);
    //        break;
    //      case "M":
    //        query = query.Where(entry => entry.M == size);
    //        break;
    //      case "L":
    //        query = query.Where(entry => entry.L == size);
    //        break;
    //      case "XL":
    //        query = query.Where(entry => entry.XL == size);
    //        break;
    //      case "XXL":
    //        query = query.Where(entry => entry.XXL == size);
    //        break;
    //      case "XXXL":
    //        query = query.Where(entry => entry.XXXL == size);
    //        break;
    //      case "XXXXL":
    //        query = query.Where(entry => entry.XXXXL == size);
    //        break;
    //   }


    //    return await query.ToListAsync();
    //  }
    
  }
}