using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class w1 : CommunityToolkit.Maui.Views.Popup
{
    public w1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}