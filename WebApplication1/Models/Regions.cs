﻿namespace WebApplication1.Models
{
    public class Regions
    {
        public Guid Id { get; set; }
        public string  Code { get; set; }
        public string name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }
        //Navigation

        public IEnumerable<Walk> Walks { get; set; }
    }
}
