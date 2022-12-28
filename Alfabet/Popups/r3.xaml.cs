using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class r3 : CommunityToolkit.Maui.Views.Popup
{
    public r3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}