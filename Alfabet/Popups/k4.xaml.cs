using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class k4 : CommunityToolkit.Maui.Views.Popup
{
    public k4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}