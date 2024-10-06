using FlightSystem.Core.DTO;
using FlightSystem.Core.Services;
using FlightSystem.Infra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class TestimonialController : ControllerBase
    {

        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpPost]
        [Route("CreateTestimonial")]
        void CreateTestimonial(TestimonialDTO testimonial)
        {
            _testimonialService.CreateTestimonial(testimonial);
            
        }

        [HttpDelete]
        [Route("DeleteTestimonial/{id}")]
        void DeleteTestimonial(int testimonialId)
        {
            _testimonialService.DeleteTestimonial(testimonialId);
            
        }

        [HttpGet]
       public  List<TestimonialDTO> GetAllTestimonials()
        {
             return _testimonialService.GetAllTestimonials();  
        }

        [HttpPut("{id}/status")]
        void ChangeTestimonialStatus(int testimonialId, string status)
        {
            _testimonialService.ChangeTestimonialStatus(testimonialId, status);
          
        }
    }
}
