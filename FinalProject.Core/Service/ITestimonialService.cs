using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Service
{
    public interface ITestimonialService
    {
        List<Testimonial> GetAlltestimonial();
        void CREATEtestimonial(Testimonial testimonial);
        void UPDATEtestimonial(Testimonial testimonial);
        Testimonial GettestimonialtById(int id);
        void Deletetestimonial(int id);
        List<userTestimonialsDTO> GetReviews();

        List<userTestimonialsDTO> getusertestimonial();
        List<userTestimonialsDTO> GetAlltestimonialAccepted();
        List<userTestimonialsDTO> ReturnLastthreeAccepted();

    }
}
