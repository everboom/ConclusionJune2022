using Demos.Day4.DemoModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demos.Day4.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly CourseDbContext _context;

        public RoomController(CourseDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return _context.Rooms;
        }

        // get by id
        // delete

        [HttpPost]
        public void Post(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

    }
}
