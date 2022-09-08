using Newtonsoft.Json.Linq;
using System.Collections;

namespace ControlTemplate.Controls.TabelControl;

public partial class TabelControl : StackLayout
{
    public static List<string> Atribut { get; set; }
	public TabelControl()
	{
       
		InitializeComponent();
        Atribut = new List<string>();
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
        //if (newValue != null)
            //controls.ContentHeader.Content = (View)newValue;
    }

    public View HeaderTabel
    {
        get => (View)GetValue(HeaderTabelProperty);
        set { SetValue(HeaderTabelProperty, value); }
    }
    #endregion

    #region Content
    public static readonly BindableProperty ContentProperty = BindableProperty.Create(
        propertyName: nameof(Content),
        returnType: typeof(View),
        declaringType: typeof(TabelControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.OneWay);

    /*private static void ContentTabelPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (TabelControl)bindable;
        if (newValue != null)
            controls.KontenTabel.Content = (ContentView)newValue;
    }*/
    public View Content
    {
        get => (View)GetValue(ContentProperty);
        set { SetValue(ContentProperty, value); }
    }
    #endregion

    #region Data
    public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
        propertyName: nameof(ItemsSource),
        returnType: typeof(IList),
        declaringType: typeof(TabelControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: OnItemSourceChanged);
    
    public static void OnItemSourceChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var controls = (TabelControl)bindable;
        var json = System.Text.Json.JsonSerializer.Serialize(newValue);
        JArray array = JArray.Parse(json);
        var loop = 0;
        foreach (JObject content in array)
        {
            if (loop < 1)
                foreach (JProperty prop in content.Properties())
                {
                    controls.Header.Add(new HeaderTabelControl { JudulKolom = $"{prop.Name}" });
                    Atribut.Add(prop.Name);
                    
                    //Console.WriteLine(prop.Name);
                }
                loop++;
        }

    }

    public IList ItemsSource
    {
        get => (IList)GetValue(ItemsSourceProperty);
        set => SetValue(ItemsSourceProperty, value);
    }

    
    #endregion    
}