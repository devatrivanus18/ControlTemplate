using ControlLibrary.Controls;
using ControlTemplate.ViewModels;

namespace ControlTemplate.Views;

public partial class ModalCustomer : pthModal
{
	public ModalCustomer()
	{
		InitializeComponent();
		BindingContext = new vmData();
	}
}