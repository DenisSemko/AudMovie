using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AudMovie.Models;
using AudMovie.Dtos;

namespace AudMovie.App_Start
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