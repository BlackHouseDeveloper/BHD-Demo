namespace BHD_Demo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

   	 	// Set the initial route to the login page
    	Shell.Current.GoToAsync("//welcome");

	}

	protected override void OnStart()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
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
