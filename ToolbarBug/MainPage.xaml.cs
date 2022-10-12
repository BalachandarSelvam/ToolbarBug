
namespace ToolbarBug;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        if ((sender as ToolbarItem).Text == "Open")
        {
            ToolbarItem.Text = "Close";
            ToolbarItem.IconImageSource = ImageSource.FromResource("ToolbarBug.NewFolder.close1.jpg");
        }
        else
        {
            ToolbarItem.Text = "Open";
            ToolbarItem.IconImageSource = ImageSource.FromResource("ToolbarBug.NewFolder.open1.jpg");
        }
    }
}

