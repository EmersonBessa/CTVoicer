﻿using AutoMapper;
using CTVoicer.Veiculos.Web.ViewModels;
using CTVoicer.Veiculos.Bussiness.Models;

namespace CTVoicer.Veiculos.Web.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Veiculo, VeiculoViewModel>().ReverseMap();
            CreateMap<TipoVeiculo, TipoVeiculoViewModel>().ReverseMap();
            CreateMap<Cor, CorViewModel>().ReverseMap();
        }
    }
}
