using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Dtos
{
    public class GuestDto
    {
        public int Id { get; set; }
        public int Phone { get; set; }
        public bool Status { get; set; }
        public int PackageId { get; set; }
        public PackageDto Package { get; set; }

    }
}
