using restful.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restful.core.Dtos
{
    public class PackageDto
    {
        public int Id { get; set; }
        public string PackgeName { get; set; }
        public double Price { get; set; }
       
    }
}
