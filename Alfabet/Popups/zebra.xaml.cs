using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class zebra : CommunityToolkit.Maui.Views.Popup
{
    public zebra()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}