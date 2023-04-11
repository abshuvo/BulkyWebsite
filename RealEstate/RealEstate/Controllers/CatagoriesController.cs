using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate.model;
using System.Xml.Linq;

namespace RealEstate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private List<Catagory> catagories = new List<Catagory>()
        {
            new Catagory(){ Id=0,Name="Apartment",ImageUrl="Apartment.jpg"},
                new Catagory(){ Id=1,Name="Commercial",ImageUrl="Commercial.jpg"},
        };

        [HttpGet]

        public IEnumerable<Catagory> Get()
        {
            return catagories;
        }

        [HttpPost]

        public void Post([FromBody] Catagory catagory)
        {
            catagories.Add(catagory);
        }
        [HttpPut("{Id}")]
        public void Put(int Id, [FromBody] Catagory catagory)
        {
            catagories[Id] = catagory;
        }

        [HttpDelete("{id}")]
        public void Delete(int id) { 
        catagories.RemoveAt(id);
        }
    }
}
