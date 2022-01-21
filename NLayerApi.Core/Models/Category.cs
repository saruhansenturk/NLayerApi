﻿namespace NLayerApi.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }  //navigation property*
    }
}
