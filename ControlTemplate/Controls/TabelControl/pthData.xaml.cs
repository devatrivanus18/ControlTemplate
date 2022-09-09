
namespace ControlTemplate.Controls.TabelControl;

public partial class pthData : Grid
{
    public pthData()
	{
		var x = TabelControl.Atribut;
		InitializeComponent();
		foreach (var item in x)
		{
			var label = new Label();
            label.Padding = 10;
            label.HorizontalOptions = LayoutOptions.CenterAndExpand;
            label.HorizontalTextAlignment = TextAlignment.Center;
            label.SetBinding(Label.TextProperty, item);
			DataKolom.Add(label);
        }
    }
}