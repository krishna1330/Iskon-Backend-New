using Iskcon.Business;
using Iskcon.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Iskcon_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IskconDbContext DbContext;

        public RegistrationController(IConfiguration configuration, IskconDbContext _DbContext)
        {
            this.DbContext = _DbContext;
        }

        [HttpPost("NewRegistration")]
        [Consumes("multipart/form-data")]
        public async Task<ActionResult> NewRegistrationAsync([FromForm] RegisteredMembers registeredMember, IFormFile photo, IFormFile signature)
        {
            try
            {
                RegistrationDAC registrationDAC = new RegistrationDAC();
                string res = await registrationDAC.NewRegistrationAsync(DbContext, registeredMember, photo, signature);

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
