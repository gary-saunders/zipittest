using System;
using System.Text.Json;
namespace ZipitTest;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

        private async void OpenBrowserButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // await Launcher.OpenAsync(new Uri("http://192.168.50.147:4200"));
				var data = new
				{
					value = "0000268656",
					completedRedirectUrl = "boccapp://setup/setup",
					redirectOnCompletion = false
				};

				// Serialize the object to JSON
				var json = JsonSerializer.Serialize(data);

				// Encode the JSON string
				var encodedData = Uri.EscapeDataString(json);

				// Construct the URL
				var zipItUserPortal = $"https://hunter.stage.zipiteng.com/landing/route?pf=add-device&pfParams={encodedData}";



                // await Launcher.OpenAsync(new Uri(zipItUserPortal));
				await Browser.OpenAsync(zipItUserPortal, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., invalid URL, no browser available)
                Console.WriteLine($"Error opening browser: {ex.Message}");
            }
        }
}

