using BHD_Demo.Services.Store;
using BHD_Demo.Services.Store.AppEnvironment;
using BHD_Demo.Services.Store.Settings;
using BHD_Demo.Services.Store.Theme;
using BHD_Demo.Views.Main;

namespace BHD_Demo;

public partial class App : Application
{

    private readonly ISettingsService _settingsService;
    private readonly INavigationService _navigationService;
    private readonly ITheme _theme;
    private readonly IAppEnvironmentService _appEnvironmentService;

    public App(ISettingsService settingsService,
        INavigationService navigationService,
        ITheme theme,
        IAppEnvironmentService appEnvironmentService)
    {

        _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
        _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        _theme = theme ?? throw new ArgumentNullException(nameof(theme));
        _appEnvironmentService = appEnvironmentService ?? throw new ArgumentNullException(nameof(appEnvironmentService));

        // Initialize the app
        InitApp();

        InitializeComponent();





        

    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell(_navigationService));
        return window;

    }

    private void InitApp()
    {

        // First-launch logic
        if (VersionTracking.IsFirstLaunchEver)
        {
            _settingsService.UseMocks = true;
        }

        // Configure environment dependencies
        _appEnvironmentService.UpdateDependencies(_settingsService.UseMocks);

        // Apply theme settings
        SetTheme();
    }



    private void SetTheme()
    {
        if (Current.RequestedTheme == AppTheme.Dark)
        {
            _theme.SetStatusBarColor(Colors.Black, false);
        }
        else
        {
            _theme.SetStatusBarColor(Colors.White, true);
        }
    }

    private async void SetInitialRoute()
    {

        try
            {
                // Ensure that the navigation service is not null
                if (_navigationService == null)
                {
                    throw new InvalidOperationException("Navigation service is not initialized.");
                }

                // Ensure that AppShell.Current is not null
                if (Shell.Current == null)
                {
                    throw new InvalidOperationException("Shell.Current is not initialized.");
                }

                string initialRoute = await DetermineInitialRouteAsync();
                await Shell.Current.GoToAsync($"//{initialRoute}");
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                Console.WriteLine($"Error in SetInitialRoute: {ex.Message}");
                throw;
            }
    }

    private async Task<string> DetermineInitialRouteAsync()
    {
        var userToken = await _settingsService.GetUserTokenAsync();
        if (userToken != null && !string.IsNullOrWhiteSpace(userToken.AccessToken))
        {
            return "dashboard";
        }

        return "welcome";
    }

    protected override void OnStart()
    {
        base.OnStart();
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
        // Set the initial route to the login page
        SetInitialRoute();
    }

    public static void HandleAppActions(AppAction appAction)
    {
        if (Current is not App app)
        {
            return;
        }

        app.Dispatcher.Dispatch(
            async () =>
            {
                if (appAction.Id.Equals(AppActions.ViewProfileAction.Id))
                {
                    await app._navigationService.NavigateToAsync("//StoreTab/Profile");
                }
            });
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        // Handle or log the exception
        Console.WriteLine($"Unhandled exception: {e.ExceptionObject}");
    }

    private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
    {
        // Handle or log the exception
        Console.WriteLine($"Unobserved task exception: {e.Exception}");
        e.SetObserved();
    }

}