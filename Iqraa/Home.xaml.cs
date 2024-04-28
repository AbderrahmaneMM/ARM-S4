namespace Iqraa;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Layla_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new Layla());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Arnab_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new Arnab());
    }

    private void Namla_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new Namla());
    }
}