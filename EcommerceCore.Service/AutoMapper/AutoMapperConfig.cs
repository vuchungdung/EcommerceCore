using AutoMapper;
using EcommerceCore.Application.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelMappingProfile());
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
