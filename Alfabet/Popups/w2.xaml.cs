using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class w2 : CommunityToolkit.Maui.Views.Popup
{
    public w2()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}