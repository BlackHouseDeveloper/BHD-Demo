using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BHD_Demo.Models.GroupApp;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.GroupApp
{
    public partial class AddGroupPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string groupName;

        [ObservableProperty]
        private string description;

        public RelayCommand SaveGroupCommand { get; }

        public AddGroupPageViewModel()
        {
            SaveGroupCommand = new RelayCommand(OnSaveGroup);
        }

        private async void OnSaveGroup()
        {
            if (!string.IsNullOrWhiteSpace(GroupName))
            {
                // Create a new group and add it to the Groups collection in GroupViewModel
                var newGroup = new Group(GroupName, Description);

                // Pass the new group data back to GroupViewModel
                MessagingCenter.Send(this, "AddGroup", newGroup);

                // Navigate back to GroupAppPage
                await Shell.Current.GoToAsync($"///groupdetail");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a group name.", "OK");
            }
        }
    }
}
