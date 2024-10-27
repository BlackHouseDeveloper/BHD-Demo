namespace BHD_Demo.ViewModels.Service
{
    public class ServiceDetailViewModel : BaseViewModel
    {
        public string ServiceDate { get; set; }
        public string ServiceTime { get; set; }

        public ServiceDetailViewModel(string serviceDate, string serviceTime)
        {
            ServiceDate = serviceDate;
            ServiceTime = serviceTime;
        }
    }
}
