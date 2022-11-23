using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class yeti : CommunityToolkit.Maui.Views.Popup
{
    public yeti()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}