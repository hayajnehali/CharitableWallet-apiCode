using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface ITestimonialRepository
    {
        
        List<Testimonial> GetAlltestimonial();
        void CREATEtestimonial(Testimonial testimonial);
        void UPDATEtestimonial( Testimonial testimonial);
        Testimonial GettestimonialtById(int id);
        void Deletetestimonial(int id);
        List<userTestimonialsDTO> getusertestimonial();
        List<userTestimonialsDTO> GetReviews();

        List<userTestimonialsDTO> GetAlltestimonialAccepted();
        List<userTestimonialsDTO> ReturnLastthreeAccepted();
    }
}
