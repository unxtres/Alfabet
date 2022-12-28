using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class z3 : CommunityToolkit.Maui.Views.Popup
{
    public z3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}