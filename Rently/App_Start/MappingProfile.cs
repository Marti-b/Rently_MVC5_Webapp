using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Rently.Dtos;
using Rently.Models;

namespace Rently.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            // Domain to Dto
            //API -> Outbound
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();


            // Dto to Domain
            // API <- Inbound
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}