using AutoMapper;
using Holtz_Academy.API.Entities;
using Holtz_Academy.API.Entities.InputModels;
using Holtz_Academy.API.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holtz_Academy.API.Data
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<BranchInputModel, Branch>();
            CreateMap<Branch, BranchViewModel>();
        }
    }
}
