using restful.core.Dtos;
using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core
{
    public class Mapping
    {
        public GuestDto MapToGuestDto(Guest guest)
        {
            return new GuestDto { Id = guest.Id, Phone = guest.Phone, Status = guest.Status/*, Package=guest.Package */ };
        }

    }
}
