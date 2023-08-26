using IKAPI.Contexts;
using IKAPI.Dtos;
using IKAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase {

        private readonly Databasecontext _context;

        public CompanyController(Databasecontext context) { _context = context; }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompanies()
        {
            var companies = _context.Companies.ToList();
            return Ok(companies);
        }

        
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany([FromBody] DtoCreateCompany request)
        {
            Company yenifirmam = new()
            {
                Name = request.Name,
            };

            _context.Companies.Add(yenifirmam);
            _context.SaveChanges();
         
            return Ok();
        }

        
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCompany([FromBody] DtoUpdateCompany request) {

            Company? arananfirma = _context.Companies.
            Where(firma => firma.Id == Guid.Parse(request.Id)).FirstOrDefault();

            if (arananfirma == null)    return NotFound();
            arananfirma.Name= request.Name;
            _context.SaveChanges();

            return Ok();
        }


        [HttpDelete("[action]/{Id}")]
        public async Task<IActionResult> DeleteCompany([FromRoute] string Id)
        {
            Company? arananfirma = _context.Companies
                .Where(firma => firma.Id == Guid.Parse(Id)).FirstOrDefault();

            if (arananfirma == null)
                return NotFound();

            _context.Companies.Remove(arananfirma);
            _context.SaveChanges();

            return Ok();
        }
    }
}
