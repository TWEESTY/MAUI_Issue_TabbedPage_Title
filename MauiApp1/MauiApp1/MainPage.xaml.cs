namespace MauiApp1;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();
    }


	protected override void OnAppearing()
	{
		base.OnAppearing();

        this.Title = "On Appearing Title";

        var timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromMilliseconds(2000);
        timer.Tick += (s, e) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                this.Title = DateTime.Now.ToString();
            });
        };
        timer.Start();
    }
}

