using System.Collections.Generic;
using CMS.BusinessLayer.Models;
using CMS.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CMS.WebAPI.Controllers
{
    [Route("api/Contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IDataRepository<Contact> _dataRepository;

        public ContactController(IDataRepository<Contact> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Contact
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Contact> Contacts = _dataRepository.GetAll();
            return Ok(Contacts);
        }

        // GET: api/Contact/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Contact Contact = _dataRepository.Get(id);

            if (Contact == null)
            {
                return NotFound("The Contact record couldn't be found.");
            }

            return Ok(Contact);
        }

        // POST: api/Contact
        [HttpPost]
        public IActionResult Post([FromBody] Contact Contact)
        {
            if (Contact == null)
            {
                return BadRequest("Contact is null.");
            }

            _dataRepository.Add(Contact);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Contact.ContactId },
                  Contact);
        }

        // PUT: api/Contact/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Contact Contact)
        {
            if (Contact == null)
            {
                return BadRequest("Contact is null.");
            }

            Contact ContactToUpdate = _dataRepository.Get(id);
            if (ContactToUpdate == null)
            {
                return NotFound("The Contact record couldn't be found.");
            }

            _dataRepository.Update(ContactToUpdate, Contact);
            return NoContent();
        }

        // DELETE: api/Contact/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Contact Contact = _dataRepository.Get(id);
            if (Contact == null)
            {
                return NotFound("The Contact record couldn't be found.");
            }

            _dataRepository.Delete(Contact);
            return NoContent();
        }
    }
}