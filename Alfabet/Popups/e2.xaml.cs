using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class e2 : CommunityToolkit.Maui.Views.Popup
{
    public e2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}