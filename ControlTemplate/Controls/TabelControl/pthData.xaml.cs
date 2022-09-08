
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
			var e = new ContentTabel();
			//e.SetBinding(e.IsiKolom, new Binding(item));
			//DataKolom.Add(new ContentTabel { IsiKolom = SetBinding() }) ;
        }
    }
}