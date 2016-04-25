using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilityLog.DataAccess.Entities;
using AgilityLog.ServiceLayer.Models.KennelClub;
using AgilityLog.ServiceLayer.Models.Uka;
using AutoMapper;

namespace AgilityLog.DataAccess
{
    public class AutoMapperDataAccessProfile : Profile
    {
        protected override void Configure()
        {
            this.CreateMap<AgilityClass, KcClass>();
            this.CreateMap<KcClass, AgilityClass>();

            this.CreateMap<AgilityClass, UkaClass>();
            this.CreateMap<UkaClass, AgilityClass>();
        }
    }
}
