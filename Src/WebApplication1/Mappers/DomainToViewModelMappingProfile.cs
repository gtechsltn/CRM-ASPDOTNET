﻿using AutoMapper;
using WebApplication1.DTO;
using WebApplication1.Helpers;

namespace WebApplication1
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CustomerDto, CustomerModel>()
                .ForMember(x => x.Gender, opt => opt.MapFrom(source => source.Gender.MakeGender()))
                .ForMember(x => x.DoBInStr, opt => opt.MapFrom(source => source.DoB.ShowDateOnly()));
        }
    }
}