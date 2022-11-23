using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class pies : CommunityToolkit.Maui.Views.Popup
{
    public pies()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}