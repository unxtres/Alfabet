using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class c2 : CommunityToolkit.Maui.Views.Popup
{
    public c2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}