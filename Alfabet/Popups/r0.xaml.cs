using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class r0 : CommunityToolkit.Maui.Views.Popup
{
    public r0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}