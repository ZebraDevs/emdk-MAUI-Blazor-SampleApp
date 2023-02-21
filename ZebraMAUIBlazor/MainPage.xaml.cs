using CommunityToolkit.Mvvm.Messaging;

namespace ZebraMAUIBlazor;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        WeakReferenceMessenger.Default.Register<string>(this, (r, m) =>
        {
            MainThread.BeginInvokeOnMainThread(() => {  });
        });

       // lbWelcome.Text += " v" + AppInfo.VersionString;
    }
}
