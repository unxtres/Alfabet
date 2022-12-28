using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class c1 : CommunityToolkit.Maui.Views.Popup
{
    public c1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}