using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class f0 : CommunityToolkit.Maui.Views.Popup
{
    public f0()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}