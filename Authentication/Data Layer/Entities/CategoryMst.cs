using System;
using System.Collections.Generic;

namespace Data_Layer.Entities;

public partial class CategoryMst
{
    public int CategoryId { get; set; }

    public string Categoryname { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDelete { get; set; }

    public bool CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool UpdateBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
