using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class waz : CommunityToolkit.Maui.Views.Popup
{
    public waz()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}