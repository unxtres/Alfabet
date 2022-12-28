using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class b0 : CommunityToolkit.Maui.Views.Popup
{
    public b0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}