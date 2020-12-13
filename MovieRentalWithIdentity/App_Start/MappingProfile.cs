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
            Mapper.CreateMap<Customer, CustomerDtos>();
            Mapper.CreateMap<CustomerDtos, Customer>();
        }
    }
}