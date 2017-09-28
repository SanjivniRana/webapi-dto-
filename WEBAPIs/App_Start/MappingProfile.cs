using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBAPIs.Dto;
using WEBAPIs.Models;

namespace WEBAPIs.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Emp, EmpDto>();
            CreateMap<EmpDto, Emp>();
        }
    }
}