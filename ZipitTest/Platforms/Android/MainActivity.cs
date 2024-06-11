using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using MauiApp1;

namespace ZipitTest;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]

[IntentFilter(new[] { Android.Content.Intent.ActionView },
    DataScheme = "boccapp",
    DataHost = "setup",
    DataPathPrefix = "/setup",
    AutoVerify = false,
    Categories = new[] { Android.Content.Intent.ActionView, Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]
public class MainActivity : MauiAppCompatActivity
{
    
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        Intent intent = Intent;
        var action = intent.Action;
        var strLink = intent.DataString;
        if (Intent.ActionView == action && !string.IsNullOrWhiteSpace(strLink))
        {
            //handle intent routing
            // Shell.Current.GoToAsync($"//{nameof(SecondPage)}?IdFromURL={id}", true);
            // Shell.Current.GoToAsync($"//{nameof(SecondPage)}", true);

            //Write code to navigate shell to the page with a class SecondPage
            Shell.Current.GoToAsync(nameof(SecondPage));
        }
        base.OnCreate(savedInstanceState);
    }
}

