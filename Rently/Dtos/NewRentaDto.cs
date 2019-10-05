using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rently.Dtos
{
    public class NewRentaDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }

    }
}