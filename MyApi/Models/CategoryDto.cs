﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Models
{
    public class CategoryDto: BaseDto<CategoryDto,Category>
    {

        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }

        public string ParentCategoryName { get; set; } //=> mapped from ParentCategory.Name
    }
}