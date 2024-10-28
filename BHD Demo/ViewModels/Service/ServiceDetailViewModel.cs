using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace BHD_Demo.ViewModels.Service
{
    // Query properties
    [QueryProperty(nameof(ServiceDateString), "serviceDate")]
    [QueryProperty(nameof(ServiceTimeString), "serviceTime")]
    public partial class ServiceDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        private DateTime? serviceDate;
        [ObservableProperty]
        private TimeSpan? serviceTime;

        public RelayCommand NavigateToServicechedulerCommand { get; }

        public ServiceDetailViewModel()
        {

            NavigateToServicechedulerCommand = new RelayCommand(async () => await Shell.Current.GoToAsync("//scheduler"));
        }

        // Query properties
        public string ServiceDateString
        {
            set
            {
                if (DateTime.TryParse(value, out var date))
                {
                    ServiceDate = date;
                    OnPropertyChanged(nameof(ServiceDate)); // Explicitly raise PropertyChanged event
                }
            }
        }

        public string ServiceTimeString
        {
            set
            {
                if (TimeSpan.TryParse(value, out var time))
                {
                    ServiceTime = time;
                    OnPropertyChanged(nameof(ServiceTime)); // Explicitly raise PropertyChanged event
                }
            }
        }

        protected override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.PropertyName == nameof(ServiceDate) || e.PropertyName == nameof(ServiceTime))
            {
                Console.WriteLine($"ServiceDate changed: {ServiceDate}");
                Console.WriteLine($"ServiceTime changed: {ServiceTime}");
            }
        }
    }
}
