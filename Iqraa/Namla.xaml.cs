//using static Android.Graphics.ImageDecoder;
//using static Android.Provider.MediaStore;

namespace Iqraa;

public partial class Namla : ContentPage
{
	public Namla()
	{
		InitializeComponent();
	}
    int count = 0;
    private void strta_Clicked(object sender, EventArgs e)
    {

        if (count==0)
        {
            count = 1;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Namla\\Namla (1).jpg";
        }
        else
        {

            count = 0;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Namla\\Namla (0).jpg";
        }
      
    }

    private void Home_Clicked(object sender, EventArgs e)
    {
        Home.Navigation.PushAsync(new Home());
    }

    private void next_Clicked(object sender, EventArgs e)
    {
        pres.IsEnabled = true;
        if (count < 8)
        {
            count++;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Namla\\Namla (" + count + ").jpg";
        }
        else
        {
            next.IsEnabled = false;
            l.Text = " النهاية:الصفحة رقم...08";
        }
    }

    private void pres_Clicked(object sender, EventArgs e)
    {
        next.IsEnabled = true;
        if (count > 0)
        {
            count--;
            Updatecount();
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Namla\\Namla ("+count+").jpg";
        }
        else
        {
            safha.Source = "C:\\Users\\DELL\\source\\repos\\ARM S4\\Iqraa\\Resources\\Images\\Namla\\Namla (0).jpg";
            pres.IsEnabled = false;
        }
    }
    private void Updatecount()
    {
        string cs = count.ToString();
        l.Text = "0" +cs + ":الصفحة رقم";
    }
}