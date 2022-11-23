using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class xylofon : CommunityToolkit.Maui.Views.Popup
{
    public xylofon()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}