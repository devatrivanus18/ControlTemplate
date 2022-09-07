using static System.Net.Mime.MediaTypeNames;

namespace ControlTemplate.Controls.TabelControl;

public partial class HeaderTabelControl : Frame
{
	public HeaderTabelControl()
	{
		InitializeComponent();
	}

    #region Text
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(HeaderTabelControl), string.Empty, BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    #endregion

}