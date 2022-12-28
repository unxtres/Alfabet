using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class w4 : CommunityToolkit.Maui.Views.Popup
{
    public w4()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}