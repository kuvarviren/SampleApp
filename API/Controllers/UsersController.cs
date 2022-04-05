using API.Data;
using API.Entitities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class UsersController:BaseApiController
    { 
        private readonly AppDbContext _context;
        public UsersController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           return await _context.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        [HttpGet("greet")]
        public ActionResult<string> GetModifiedName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return BadRequest("name is null or empty");
            }            
            string result = string.Format("Hello {0}!", name); 
            return Ok(new {name=result});
        }

    }
}
