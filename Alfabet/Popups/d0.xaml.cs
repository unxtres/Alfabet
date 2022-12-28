using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class d0 : CommunityToolkit.Maui.Views.Popup
{
    public d0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}