﻿namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDeleted { get; set; }
        public string CreateDate { get; set; }

    }
}
