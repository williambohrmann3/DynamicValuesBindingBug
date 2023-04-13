namespace OnPlatformDynamicValuesBug;

public partial class MainPage : ContentPage
{
	public Model m { get; set; }
	public MainPage()
	{
		InitializeComponent();
		m = new Model();
		BindingContext = m;
	}
}

