using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class lew : CommunityToolkit.Maui.Views.Popup
{
    public lew()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}