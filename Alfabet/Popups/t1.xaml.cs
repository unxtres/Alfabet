using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class t1 : CommunityToolkit.Maui.Views.Popup
{
    public t1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}