namespace ControlTemplate.Controls.TabelControl;

public partial class ContentTabel : Frame
{
	public ContentTabel()
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