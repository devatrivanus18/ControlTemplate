using System.Collections.ObjectModel;

namespace ControlTemplate.Controls.TabelControl;

public partial class TabelControl : StackLayout
{
	public TabelControl()
	{
		InitializeComponent();
	}

    #region HeaderTabel
    public static readonly BindableProperty HeaderTabelProperty = BindableProperty.Create(
        propertyName: nameof(HeaderTabel),
        returnType: typeof(View),
        declaringType: typeof(TabelControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: HeaderTabelPropertyChanged);

    private static void HeaderTabelPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (TabelControl)bindable;
        if (newValue != null)
            controls.ContentHeader.Content = (View)newValue;
    }

    public View HeaderTabel
    {
        get => (View)GetValue(HeaderTabelProperty);
        set { SetValue(HeaderTabelProperty, value); }
    }
    #endregion

    #region ContentTabel
    public static readonly BindableProperty ContentTabelProperty = BindableProperty.Create(
        propertyName: nameof(ContentTabel),
        returnType: typeof(View),
        declaringType: typeof(TabelControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay);

    /*private static void ContentTabelPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (TabelControl)bindable;
        if (newValue != null)
            controls.KontenTabel.Content = (View)newValue;
    }*/
    public View ContentTabel
    {
        get => (View)GetValue(ContentTabelProperty);
        set { SetValue(ContentTabelProperty, value); }
    }
    #endregion

    #region Data
    public static readonly BindableProperty DataListProperty = BindableProperty.Create(
        propertyName: nameof(Data),
        returnType: typeof(ObservableCollection<object>),
        declaringType: typeof(TabelControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay);

    public ObservableCollection<object> Data
    {
        get => (ObservableCollection<object>)GetValue(DataListProperty);
        set { SetValue(DataListProperty, value); }
    }
    #endregion    
}