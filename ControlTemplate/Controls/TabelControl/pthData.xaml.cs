namespace ControlTemplate.Controls.TabelControl;

public partial class pthData : Frame
{
	public pthData()
	{
		var x = TabelControl.Atribut;
		InitializeComponent();
		foreach (var item in x)
		{
			var y = item;
			//DataKolom.Add(new ContentTabel { IsiKolom = {Binding item} });
        }
    }
}