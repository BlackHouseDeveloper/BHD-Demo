using CommunityToolkit.Mvvm.ComponentModel;

namespace BHD_Demo.ViewModels.GroupApp
{
    [QueryProperty(nameof(GroupName), "groupName")]
    [QueryProperty(nameof(Description), "description")]
    public partial class GroupDetailPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string groupName;

        [ObservableProperty]
        private string description;
    }
}
