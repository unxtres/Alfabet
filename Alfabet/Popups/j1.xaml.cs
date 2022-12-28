using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class j1 : CommunityToolkit.Maui.Views.Popup
{
    public j1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}