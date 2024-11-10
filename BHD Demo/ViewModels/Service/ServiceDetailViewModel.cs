using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using BHD_Demo.Models.Service;

namespace BHD_Demo.ViewModels.Service
{
    // Query properties for navigation
    [QueryProperty(nameof(ServiceDateString), "serviceDate")]
    [QueryProperty(nameof(ServiceTimeString), "serviceTime")]
    [QueryProperty(nameof(ServiceDescription), "serviceDescription")]
    [QueryProperty(nameof(ServiceName), "serviceName")]
    public partial class ServiceDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ScheduledService scheduledService;
         [ObservableProperty]
        private DateTime? serviceDate;
        [ObservableProperty]
        private TimeSpan? serviceTime;
        

        public RelayCommand NavigateToServiceSchedulerCommand { get; }

        public ServiceDetailViewModel()
        {
            NavigateToServiceSchedulerCommand = new RelayCommand(async () => await Shell.Current.GoToAsync("//scheduler"));
            ScheduledService = new ScheduledService(); // Initialize with a default ScheduledService instance
        }

        // Query properties
        public string ServiceDateString
        {
            set
            {
                if (DateTime.TryParse(value, out var date))
                {
                    ScheduledService.ServiceDate = date;
                    OnPropertyChanged(nameof(ScheduledService));
                }
            }
        }

        public string ServiceTimeString
        {
            set
            {
                if (TimeSpan.TryParse(value, out var time))
                {
                    ScheduledService.ServiceTime = time; // Format time as string
                    OnPropertyChanged(nameof(ScheduledService));
                }
            }
        }

        public string ServiceDescription
        {
            set
            {
                ScheduledService.Description = value;
                OnPropertyChanged(nameof(ScheduledService));
            }
        }

        public string ServiceName
        {
            set
            {
                ScheduledService.ServiceName = value;
                OnPropertyChanged(nameof(ScheduledService));
            }
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.PropertyName == nameof(ScheduledService))
            {
                Console.WriteLine($"Service Name: {ScheduledService.ServiceName}");
                Console.WriteLine($"Service Date: {ScheduledService.ServiceDate}");
                Console.WriteLine($"Service Time: {ScheduledService.ServiceTime}");
                Console.WriteLine($"Description: {ScheduledService.Description}");
            }
        }
    }
}
