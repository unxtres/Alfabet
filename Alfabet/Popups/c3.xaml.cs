using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class c3 : CommunityToolkit.Maui.Views.Popup
{
    public c3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}