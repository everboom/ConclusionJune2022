using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demos.Day4.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private static readonly List<Auto> Autos = new List<Auto>
        {
            new Auto() { Id = 0, Bouwjaar = 2001, Brandstof = 1f, MerkNaam = "Nissan" },
            new Auto() { Id = 1, Bouwjaar = 2010, Brandstof = 26f, MerkNaam = "Opel" },
            new Auto() { Id = 2, Bouwjaar = 1995, Brandstof = 10f, MerkNaam = "Renault" },
            new Auto() { Id = 3, Bouwjaar = 1996, Brandstof = 10f, MerkNaam = "Renault" },
            new Auto() { Id = 4, Bouwjaar = 1997, Brandstof = 10f, MerkNaam = "Renault" },
        };

        public DemoController()
        {

            var auto1 = new Auto() { MerkNaam = "Nissan" };
            var auto2 = new Auto() { MerkNaam = "Nissan" };
            var auto2b = auto2;

            var equal1 = auto1.Equals(auto2);

            var equal2 = auto2.Equals(auto2b);
        }

        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return Autos;
        }

        [HttpGet("getById")]
        public ActionResult<Auto> Get(int id)
        {
            var predicate = (Auto auto) => auto.Id == id;
            var match = Autos.FirstOrDefault(predicate);

            if (match != null)
                return Ok(match);

            return NotFound();
        }

        [HttpGet("getByMerkNaam")]
        public ActionResult<IEnumerable<Auto>> Get(string merkNaam)
        {
            return Ok(Autos.Where(auto => auto.MerkNaam == merkNaam));

            /*
            var results = new List<Auto>();
            foreach (var item in Autos)
            {
                if (item.MerkNaam == merkNaam)
                    results.Add(item);
            }

            return Ok(results);
            */
        }

        [HttpPost]
        public void PostAuto([FromBody]Auto auto)
        {
            auto.Id = Autos.Count;
            Autos.Add(auto);
        }

        [HttpPut]
        public ActionResult PutAuto([FromBody] Auto auto)
        {
            foreach (var existing in Autos)
            {
                
                if (existing.Id == auto.Id)
                {
                    existing.MerkNaam = auto.MerkNaam;
                    return Ok();
                }
            }

            Autos.Add(auto);
            return Ok();
        }

    }


    public class Auto
    {
        public int Id { get; set; }

        public string MerkNaam { get; set; }
        public float Brandstof { get; set; }
        public int Bouwjaar { get; set; }

    }
}
