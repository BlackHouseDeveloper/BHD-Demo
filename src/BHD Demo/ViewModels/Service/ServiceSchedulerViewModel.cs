using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using BHD_Demo.Models.Service;

namespace BHD_Demo.ViewModels.Service
{
    public partial class ServiceSchedulerViewModel : BaseViewModel
    {
        [ObservableProperty]
        public DateTime selectedDate = DateTime.Now;

        public ObservableCollection<TimeSpan> AvailableTimeSlots { get; set; }
        [ObservableProperty]
        public TimeSpan? selectedTimeSlot;

        // Collection to hold booked services
        public ObservableCollection<ScheduledService> ScheduledServices { get; private set; }

        public RelayCommand BookServiceCommand { get; }
        public RelayCommand<ScheduledService> NavigateToServiceDetailCommand { get; }

        public ServiceSchedulerViewModel()
        {
            AvailableTimeSlots = new ObservableCollection<TimeSpan>();
            ScheduledServices = new ObservableCollection<ScheduledService>();

            LoadAvailableTimeSlots();

            BookServiceCommand = new RelayCommand(OnBookService);
            NavigateToServiceDetailCommand = new RelayCommand<ScheduledService>(NavigateToServiceDetail);
        }

        private void LoadAvailableTimeSlots()
        {
            AvailableTimeSlots.Clear();
            for (int hour = 9; hour <= 17; hour++)
            {
                AvailableTimeSlots.Add(new TimeSpan(hour, 0, 0));
                AvailableTimeSlots.Add(new TimeSpan(hour, 30, 0));
            }
        }

        private async void OnBookService()
        {
            if (SelectedTimeSlot.HasValue)
            {
                var bookedService = new ScheduledService
                {
                    ServiceName = "Scheduled Service",  // Customize as needed
                    ServiceDate = SelectedDate,
                    ServiceTime = SelectedTimeSlot.Value,
                    Description = "Description for the scheduled service"  // Optional
                };

                

                await Application.Current.MainPage.DisplayAlert("Service Booked",
                    $"Service booked on {SelectedDate:MMMM dd, yyyy} at {SelectedTimeSlot.Value:hh\\:mm}.",
                    "OK");
                ScheduledServices.Add(bookedService);
                NavigateToServiceDetail(bookedService);

                SelectedTimeSlot = null;
                OnPropertyChanged(nameof(SelectedTimeSlot));
            }
        }

        private async void NavigateToServiceDetail(ScheduledService service)
        {
            if (service != null)
            {
                await Shell.Current.GoToAsync($"///servicedetail?serviceName={service.ServiceName}&serviceDate={service.ServiceDate:yyyy-MM-dd}&serviceTime={service.ServiceTime:hh\\:mm}&serviceDescription={service.Description}");
            }
        }
    }
}
