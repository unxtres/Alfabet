using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class r2 : CommunityToolkit.Maui.Views.Popup
{
    public r2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}