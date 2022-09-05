
namespace ControlTemplate.Controls;

public partial class LoginControl : ContentView
{
	public LoginControl()
	{
		InitializeComponent();
	}

    #region TextColor
    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(LoginControl), null);

    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }
    #endregion

    #region Username
    public static readonly BindableProperty UsernameProperty = BindableProperty.Create(nameof(Username), typeof(string), typeof(LoginControl), string.Empty, BindingMode.TwoWay);

    public string Username
    {
        get => (string)GetValue(UsernameProperty);
        set => SetValue(UsernameProperty, value);
    }
    #endregion

    #region Password
    public static readonly BindableProperty PasswordProperty = BindableProperty.Create(nameof(Password), typeof(string), typeof(LoginControl), string.Empty, BindingMode.TwoWay);

    public string Password
    {
        get => (string)GetValue(PasswordProperty);
        set => SetValue(PasswordProperty, value);
    }
    #endregion

    #region Command
    public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(Command), typeof(LoginControl), null, BindingMode.TwoWay);

    public Command Command
    {
        get => (Command)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }
    #endregion

}