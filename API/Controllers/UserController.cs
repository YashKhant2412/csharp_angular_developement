using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>>  GetUser() {
            return await _context.User.ToListAsync();
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int Id){
            return await _context.User.FindAsync(Id);
        }
    }
}