using AutoMapper;
using EcommerceCore.Application.ViewModels;
using EcommerceCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCore.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
