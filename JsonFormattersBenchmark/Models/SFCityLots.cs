using System.Collections.Generic;

namespace JsonFormattersBenchmark.Models
{
    public class SFCityLots
    {
        public string Type { get; set; }
        public List<Feature> Features { get; set; }
    }

    public class Feature
    {
        public string Type { get; set; }
        public Property Properties { get; set; }
        public Geometry Geometry { get; set; }
    }

    public class Property
    {
        public string MAPBLKLOT { get; set; }
        public string BLKLOT { get; set; }
        public string BLOCK_NUM { get; set; }
        public string LOT_NUM { get; set; }
        public string FROM_ST { get; set; }
        public string TO_ST { get; set; }
        public string STREET { get; set; }
        public string ST_TYPE { get; set; }
        public string ODD_EVEN { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }
        public List<List<int>> Coordinates { get; set; }
    }
}