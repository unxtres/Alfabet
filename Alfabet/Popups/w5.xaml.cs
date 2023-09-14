using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class w5 : CommunityToolkit.Maui.Views.Popup
{
    public w5()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}