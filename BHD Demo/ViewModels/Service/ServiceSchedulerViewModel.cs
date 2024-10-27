using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.Service
{
    public class ServiceSchedulerViewModel : BaseViewModel
    {
        public DateTime SelectedDate { get; set; } = DateTime.Now;
        public ObservableCollection<string> AvailableTimeSlots { get; set; }
        public string SelectedTimeSlot { get; set; }

        public ICommand BookServiceCommand { get; }
        public ICommand NavigateToServiceDetailCommand { get; }

        public ServiceSchedulerViewModel()
        {
            // Initialize available time slots
            AvailableTimeSlots = new ObservableCollection<string>();
            LoadAvailableTimeSlots();

            // Commands
            BookServiceCommand = new Command(OnBookService);
            NavigateToServiceDetailCommand = new Command(NavigateToServiceDetail);
        }

        private void LoadAvailableTimeSlots()
        {
            // Populate time slots based on selected date (e.g., each hour from 9 AM to 5 PM)
            AvailableTimeSlots.Clear();
            for (int hour = 9; hour <= 17; hour++)
            {
                AvailableTimeSlots.Add($"{hour}:00 AM");
                AvailableTimeSlots.Add($"{hour}:30 AM");
            }

            // Adjust for PM times
            for (int hour = 1; hour <= 5; hour++)
            {
                AvailableTimeSlots.Add($"{hour}:00 PM");
                AvailableTimeSlots.Add($"{hour}:30 PM");
            }
        }

        private async void OnBookService()
        {
            if (!string.IsNullOrWhiteSpace(SelectedTimeSlot))
            {
                await Application.Current.MainPage.DisplayAlert("Service Booked", 
                    $"Service booked on {SelectedDate:MMMM dd, yyyy} at {SelectedTimeSlot}.", 
                    "OK");

                // Clear selected slot after booking
                SelectedTimeSlot = null;
                OnPropertyChanged(nameof(SelectedTimeSlot));

                // Navigate to the detail page to show booking details
                NavigateToServiceDetail();
            }
        }

        private async void NavigateToServiceDetail()
        {
            await Shell.Current.GoToAsync($"servicedetail?serviceDate={SelectedDate:MMMM dd, yyyy}&serviceTime={SelectedTimeSlot}");
        }
    }
}
