using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class r1 : CommunityToolkit.Maui.Views.Popup
{
    public r1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}