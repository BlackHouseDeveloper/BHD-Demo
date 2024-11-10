namespace BHD_Demo.Models.Service
{
    public class ScheduledService
    {
        public string ServiceName { get; set; }
        public DateTime ServiceDate { get; set; }
        public TimeSpan ServiceTime { get; set; }
        public string Description { get; set; }

       
    }
}
