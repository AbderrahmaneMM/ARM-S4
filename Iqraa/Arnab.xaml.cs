namespace Iqraa;

public partial class Arnab : ContentPage
{
	public Arnab()
	{
		InitializeComponent();
	}
    
   
    int count = 0;
    private void strta_Clicked(object sender, EventArgs e)
    {

        if (count == 0)
        {
            count = 1;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Arnab\\Arnab (1).jpg";
        }
        else
        {

            count = 0;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Arnab\\Arnab (0).jpg";
        }
    }

    private void Home_Clicked(object sender, EventArgs e)
    {
        Home.Navigation.PushAsync(new Home());
    }

    private void next_Clicked(object sender, EventArgs e)
    {
        pres.IsEnabled = true;
        if (count < 26)
        {
            count++;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Arnab\\Arnab ("+count+").jpg";
        }
        else
        {
            next.IsEnabled = false;
            l.Text = " ???????:?????? ???...26";
        }
    }

    private void pres_Clicked(object sender, EventArgs e)
    {
        next.IsEnabled = true;
        if (count > 0)
        {
            count--;
            Updatecount();
            safha.Source = "C:\\Users\\DEL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Arnab\\Arnab ("+count+").jpg";
        }
        else
        {
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Arnab\\Arnab (0).jpg";
            pres.IsEnabled = false;
        }
    }
    private void Updatecount()
    {
        string cs = count.ToString();
        l.Text = "0" + cs + ":?????? ???";
    }
}