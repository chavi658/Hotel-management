using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Dtos
{
    public class RoomDto
    {
        public int Id { get; set; }
        public bool Avialable { get; set; }
        public int GuestId { get; set; }
        public GuestDto Guest { get; set; }

    }
}
