using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using BHD_Demo.Models.GroupApp;
using Microsoft.Maui.Controls;

namespace BHD_Demo.ViewModels.GroupApp
{
   public partial class GroupViewModel : BaseViewModel
    {
        public ObservableCollection<Group> Groups { get; private set; }

        [ObservableProperty]
        private Group selectedGroup;

        public RelayCommand AddGroupCommand { get; }
        public RelayCommand<Group> ViewGroupDetailsCommand { get; }

        public GroupViewModel()
        {
            Groups = new ObservableCollection<Group>
            {
                new Group("Developers", "A group for development team members"),
                new Group("Designers", "A group for design team members")
            };

            AddGroupCommand = new RelayCommand(OnAddGroup);
            ViewGroupDetailsCommand = new RelayCommand<Group>(OnViewGroupDetails);
        }

        private async void OnAddGroup()
        {
            // Navigate to an AddGroupPage (not yet created) for group creation
            await Shell.Current.GoToAsync($"///addgroup");
        }

        private async void OnViewGroupDetails(Group group)
        {
            if (group != null)
            {
                // Navigate to GroupDetailPage with the selected group's information
                await Shell.Current.GoToAsync($"///groupdetail?groupName={group.GroupName}&description={group.Description}");
            }
        }
    }
}