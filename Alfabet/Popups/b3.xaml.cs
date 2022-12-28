using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class b3
    : CommunityToolkit.Maui.Views.Popup
{
    public b3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}