namespace ControlTemplate.Controls.TabelControl;

public partial class ContentTabel : Label
{
	public ContentTabel()
	{
        var x = TabelControl.OnItemSourceChanged;
		InitializeComponent();
	}

    #region IsiKolom
    public static readonly BindableProperty IsiKolomProperty = BindableProperty.Create(nameof(IsiKolom), typeof(string), typeof(ContentTabel), string.Empty, BindingMode.TwoWay);

    public string IsiKolom
    {
        get => (string)GetValue(IsiKolomProperty);
        set => SetValue(IsiKolomProperty, value);
    }
    #endregion
}