using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using FinalProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository    testimonialRepository;
        public TestimonialService(ITestimonialRepository _testimonialRepository)
        {
            this.testimonialRepository = _testimonialRepository;
        }

        public List<Testimonial> GetAlltestimonial()
        {
            return testimonialRepository.GetAlltestimonial();
        }
        
        public List<userTestimonialsDTO> getusertestimonial()
        {
            return testimonialRepository.getusertestimonial();
        }
        public List<userTestimonialsDTO> GetAlltestimonialAccepted()
        {
            return testimonialRepository.GetAlltestimonialAccepted();

        }
        public void CREATEtestimonial(Testimonial testimonial)
        {
            testimonialRepository.CREATEtestimonial(testimonial);
        }
        public void UPDATEtestimonial(Testimonial testimonial)
        {
            testimonialRepository.UPDATEtestimonial(testimonial);
        }
        public Testimonial GettestimonialtById(int id)
        {
            return testimonialRepository.GettestimonialtById(id);
        }
        public void Deletetestimonial(int id)
        {
            testimonialRepository.Deletetestimonial(id);
        }
        public List<userTestimonialsDTO> ReturnLastthreeAccepted()
        {
            return testimonialRepository.ReturnLastthreeAccepted();
        }

        public List<userTestimonialsDTO> GetReviews()
        {
            return testimonialRepository.GetReviews();
        }

    }
}
