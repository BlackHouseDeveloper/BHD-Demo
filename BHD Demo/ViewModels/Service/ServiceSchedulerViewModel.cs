using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.Service
{
    public partial class ServiceSchedulerViewModel : BaseViewModel
    {
        [ObservableProperty]
        public DateTime selectedDate = DateTime.Now;
        public ObservableCollection<TimeSpan> AvailableTimeSlots { get; set; }
        [ObservableProperty]
        public TimeSpan? selectedTimeSlot;

        public RelayCommand BookServiceCommand { get; }
        public RelayCommand NavigateToServiceDetailCommand { get; }

        public ServiceSchedulerViewModel()
        {
            // Initialize available time slots
            AvailableTimeSlots = new ObservableCollection<TimeSpan>();
            LoadAvailableTimeSlots();

            // Commands
            BookServiceCommand = new RelayCommand(OnBookService);
            NavigateToServiceDetailCommand = new RelayCommand(NavigateToServiceDetail);
        }

        private void LoadAvailableTimeSlots()
        {
            // Populate time slots based on selected date (e.g., each hour from 9 AM to 5 PM)
            AvailableTimeSlots.Clear();
            for (int hour = 9; hour <= 17; hour++)
            {
                AvailableTimeSlots.Add(new TimeSpan(hour, 0, 0));
                AvailableTimeSlots.Add(new TimeSpan(hour, 30, 0));
            }

            // Adjust for PM times
            for (int hour = 13; hour <= 17; hour++)
            {
                AvailableTimeSlots.Add(new TimeSpan(hour, 0, 0));
                AvailableTimeSlots.Add(new TimeSpan(hour, 30, 0));
            }
        }

        private async void OnBookService()
        {
            if (SelectedTimeSlot.HasValue)
            {
                await Application.Current.MainPage.DisplayAlert("Service Booked",
                    $"Service booked on {SelectedDate:MMMM dd, yyyy} at {SelectedTimeSlot.Value:hh\\:mm}.",
                    "OK");

                // Navigate to the detail page to show booking details
                NavigateToServiceDetail();

                // Clear selected slot after booking
                SelectedTimeSlot = null;
                OnPropertyChanged(nameof(SelectedTimeSlot));
            }
        }

        private async void NavigateToServiceDetail()
        {
            if (SelectedTimeSlot.HasValue)
            {
                await Shell.Current.GoToAsync($"///servicedetail?serviceDate={SelectedDate:MMMM dd, yyyy}&serviceTime={SelectedTimeSlot.Value:hh\\:mm}");
            }
        }
    }
}
