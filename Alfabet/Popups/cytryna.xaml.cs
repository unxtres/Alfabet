using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class cytryna : CommunityToolkit.Maui.Views.Popup
{
    public cytryna()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}