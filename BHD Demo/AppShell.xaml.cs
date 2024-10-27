namespace BHD_Demo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		 Navigating += OnNavigating;
	}

 		private async void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            if (e.Target.Location.OriginalString != e.Current.Location.OriginalString)
            {
                // Ensure CurrentPage is not null
                if (CurrentPage != null)
                {
                // Apply fade-out animation before navigating
                await CurrentPage.FadeTo(0, 250);   // Fade out current page
                await Task.Delay(100);              // Small delay
                }
            }
        }

        protected override async void OnNavigated(ShellNavigatedEventArgs args)
        {
            base.OnNavigated(args);

            // Apply fade-in animation after navigating
            await CurrentPage.FadeTo(1, 250);   // Fade in new page
        }

}
