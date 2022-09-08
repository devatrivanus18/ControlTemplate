using static System.Net.Mime.MediaTypeNames;

namespace ControlTemplate.Controls.TabelControl;

public partial class HeaderTabelControl : Label
{
	public HeaderTabelControl()
	{
		InitializeComponent();
	}

    #region JudulKolom
    public static readonly BindableProperty JudulKolomProperty = BindableProperty.Create(nameof(JudulKolom), typeof(string), typeof(HeaderTabelControl), string.Empty, BindingMode.TwoWay);

    public string JudulKolom
    {
        get => (string)GetValue(JudulKolomProperty);
        set => SetValue(JudulKolomProperty, value);
    }
    #endregion

}