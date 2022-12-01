using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VL.Core.Domain;
using VL.Core.Shared.ModelViews;

namespace VL.Manager.Mappings
{
    public class AlterarClienteMappingProfile : Profile
    {
        public AlterarClienteMappingProfile()
        {
            CreateMap<AlteraCliente, Cliente>()
                .ForMember(ac => ac.UltimaAtualizacao, o => o.MapFrom(x => DateTime.Now))
                .ForMember(c => c.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date));
        }
    }
}
