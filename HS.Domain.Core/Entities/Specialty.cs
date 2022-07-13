﻿namespace HS.Domain.Core.Entities
{
    public class Specialty
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Expert>? Experts { get; set; }
    }
}