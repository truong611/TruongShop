﻿using System;
using System.Collections.Generic;
using System.Text;
using TruongShop.Data.Enums;

namespace TruongShop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    }
}
