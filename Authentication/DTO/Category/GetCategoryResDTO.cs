using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Category
{
    public class GetCategoryResDTO
    {
        public int CategoryId { get; set; }

        public string Categoryname { get; set; } = null!;
    }
}
