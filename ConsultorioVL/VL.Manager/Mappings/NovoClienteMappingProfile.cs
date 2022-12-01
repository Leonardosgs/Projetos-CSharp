using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VL.Core.Domain;
using VL.Core.Shared.ModelViews;

namespace VL.Manager.Mappings
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>()
                .ForMember(c => c.DataCriacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(c => c.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}
