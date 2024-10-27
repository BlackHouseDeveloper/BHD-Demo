using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.GroupApp
{
    public class GroupAppViewModel : BaseViewModel
    {
        public string GroupName { get; set; }
        public ICommand CreateGroupCommand { get; }

        public GroupAppViewModel()
        {
            // Command to create a group
            CreateGroupCommand = new Command(OnCreateGroup);
        }

        private async void OnCreateGroup()
        {
            if (!string.IsNullOrWhiteSpace(GroupName))
            {
                // Simulate creating the group by showing a success message
                await Application.Current.MainPage.DisplayAlert("Group Created", $"Group '{GroupName}' has been created.", "OK");
            }
            else
            {
                // Show an error message if the group name is empty
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid group name.", "OK");
            }
        }
    }
}
