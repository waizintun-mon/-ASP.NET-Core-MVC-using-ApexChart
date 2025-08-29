namespace MVC.ChartWebApp.Models
{
    public class ApexChartPieChartModel
    {
        public int[] Series { get; set; } 
        public string[] Label {  get; set; }   
    }

    public class ApexChartSeries
    {
        public string Name { get; set; }
        public string Type { get; set; }   // "column", "area", "line"
        public int[] Data { get; set; }
    }

    public class ApexMixedChartModel
    {
        public List<ApexChartSeries> Series { get; set; }
        public string[] Labels { get; set; }
    }

    public class YearQuarterData
    {
        public string Year { get; set; }
        public int Value { get; set; }
        public Dictionary<string, int> Quarters { get; set; } // e.g. Q1, Q2, Q3, Q4
    }

    public class ApexYearQuarterChartModel
    {
        public List<YearQuarterData> Data { get; set; }
    }

}
