using AutoMapper;
using MovieRentalWithIdentity.Dtos;
using MovieRentalWithIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalWithIdentity.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.ID, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.ID, opt => opt.Ignore());


        }
    }
}