namespace ControlTemplate.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

	public async void Button_Clicked(object sender, EventArgs e)
	{
        await App.Current.MainPage.Navigation.PushModalAsync(new PopupPage());
        //var popup = new pthModal();
        //this.ShowPopup(popup);
    }
}