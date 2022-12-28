using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class c0 : CommunityToolkit.Maui.Views.Popup
{
    public c0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}