namespace Iqraa;

public partial class Layla : ContentPage
{
	public Layla()
	{
		InitializeComponent();
	}

    private void strt_Click(object sender, EventArgs e)
    {

    }
    int count = 0;
    private void strt_Clicked(object sender, EventArgs e)
    {
        if (count == 0)
        {
            count = 1;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Layla\\lila (1).jpg";
        }
        else
        {

            count = 0;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Layla\\lila (0).jpg";
        }
    }

    private void Home_Clicked(object sender, EventArgs e)
    {
        Home.Navigation.PushAsync(new Home());
    }

    private void next_Clicked(object sender, EventArgs e)
    {
        pres.IsEnabled = true;
        if (count < 17)
        {
            count++;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Layla\\lila (" + count + ").jpg";
        }
        else
        {
            next.IsEnabled = false;
            l.Text = " ???????:?????? ???...17";
        }
    }

    private void pres_Clicked(object sender, EventArgs e)
    {
        next.IsEnabled = true;
        if (count > 0)
        {
            count--;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Layla\\lila ("+count+").jpg";
        }
        else
        {
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Layla\\lila (0).jpg";
            pres.IsEnabled = false;
        }
    }
    private void Updatecount()
    {
        string cs = count.ToString();
        l.Text = "0"+cs+":?????? ???";
    }
}