namespace MyuBords.Entities
{
    public class WorkItem
    {
        public string State { get; set; }
        public string Area { get; set; }
        public string IterationmPath { get; set; }
        public int Priority { get; set; }

        //Epic

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Issue

        public decimal Efford { get; set; } 
        
        //Task

        public string Activity { get; set; }
        public decimal RemainingWord { get; set; }

        public string Type { get; set; }



    }
}
