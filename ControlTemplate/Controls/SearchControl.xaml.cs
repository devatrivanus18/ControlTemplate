using System.Windows.Input;

namespace ControlTemplate.Controls;

public partial class SearchControl : Grid
{
	public SearchControl()
	{
		InitializeComponent();
	}

    #region Text
    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(SearchControl), string.Empty, BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    #endregion

    #region Event
    public static readonly BindableProperty EventProperty = BindableProperty.Create(nameof(Event), typeof(string), typeof(SearchControl), string.Empty, BindingMode.TwoWay);

    public string Event
    {
        get => (string)GetValue(EventProperty);
        set => SetValue(EventProperty, value);
    }
    #endregion

    #region ICommand
    public static readonly BindableProperty ICommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(SearchControl), null, BindingMode.TwoWay);

    public ICommand Command
    {
        get => (ICommand)GetValue(ICommandProperty);
        set => SetValue(ICommandProperty, value);
    }
    #endregion
}