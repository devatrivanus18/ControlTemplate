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

    #region SelectedCommand
    public static readonly BindableProperty SelectedCommandProperty = BindableProperty.Create(
        propertyName: nameof(SelectedCommand),
        returnType: typeof(Command),
        declaringType: typeof(TabelControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay);

    public Command SelectedCommand
    {
        get => (Command)GetValue(SelectedCommandProperty);
        set { SetValue(SelectedCommandProperty, value); }
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
            if (loop == 0)
                foreach (JProperty prop in content.Properties())
                {
                    
                    var x = Atribut.Where(e => e.Contains(prop.Name));
                    if (!x.Any())
                    {
                        Atribut.Add(prop.Name);
                        var label = new Label();
                        label.Padding = 10;
                        label.HorizontalOptions = LayoutOptions.CenterAndExpand;
                        label.HorizontalTextAlignment = TextAlignment.Center;
                        label.Text = prop.Name;
                        label.FontAttributes = FontAttributes.Bold;
                        controls.Header.Add(label);
                    }
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