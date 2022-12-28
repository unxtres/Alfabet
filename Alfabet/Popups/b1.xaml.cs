using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class b1
    : CommunityToolkit.Maui.Views.Popup
{
    public b1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}