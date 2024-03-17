﻿using InGreedIoApi.Model;

namespace InGreedIoApi.POCO
{
    public class CompanyInfoPOCO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NIP { get; set; }
        public ICollection<ApiUser> Users { get; set; }
    }
}