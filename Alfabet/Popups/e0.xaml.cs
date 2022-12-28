using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class e0 : CommunityToolkit.Maui.Views.Popup
{
    public e0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}