using System;

namespace ProjectRio.Data
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
        public string Description { get; set; }
    }
}
