﻿using Domain.Common;

namespace Domain.Entities
{
    public class Basket : BaseEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }
    }
}
