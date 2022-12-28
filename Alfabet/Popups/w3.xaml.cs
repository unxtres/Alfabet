using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class w3 : CommunityToolkit.Maui.Views.Popup
{
    public w3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}