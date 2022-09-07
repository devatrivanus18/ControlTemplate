using ControlTemplate.ViewModels;

namespace ControlTemplate.Views;

public partial class CustomTabelPage : ContentPage
{
	public CustomTabelPage()
	{
		InitializeComponent();
		BindingContext = new vmData();
		
	}
}