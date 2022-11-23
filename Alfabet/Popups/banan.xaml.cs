using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class banan : CommunityToolkit.Maui.Views.Popup
{
    public banan()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}