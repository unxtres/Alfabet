using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class b2
    : CommunityToolkit.Maui.Views.Popup
{
    public b2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}