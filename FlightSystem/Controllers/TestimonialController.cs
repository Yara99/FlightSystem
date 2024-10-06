using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using FlightSystem.Infra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {

        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpPost]
        [Route("CreateTestimonial")]
        public void CreateTestimonial(TestimonialDTO testimonial)
        {
            _testimonialService.CreateTestimonial(testimonial);
            
        }

        [HttpDelete]
        [Route("DeleteTestimonial/{id}")]
        public void DeleteTestimonial(int testimonialId)
        {
            _testimonialService.DeleteTestimonial(testimonialId);
            
        }

        [HttpGet]
        public List<TestimonialDTO> GetAllTestimonials()
        {
             return _testimonialService.GetAllTestimonials();  
        }

        [HttpPut]
        [Route("ChangeTestimonialStatus/{testimonialId}/{status}")]
        public void ChangeTestimonialStatus(int testimonialId, string status)
        {
            _testimonialService.ChangeTestimonialStatus(testimonialId, status);
        }
    }
}
