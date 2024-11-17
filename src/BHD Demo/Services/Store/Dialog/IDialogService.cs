namespace BHD_Demo.Services.Store;

public interface IDialogService
{
    Task ShowAlertAsync(string message, string title, string buttonLabel);
}