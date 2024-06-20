using restful.core.Dtos;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core
{
    public class MappingFrofile:Mapping
    {
        CreateMap<GuestDto,Guest>().ReverseMap();

    }
}
