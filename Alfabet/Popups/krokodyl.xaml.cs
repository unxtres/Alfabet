using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class krokodyl : CommunityToolkit.Maui.Views.Popup
{
    public krokodyl()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}