using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class u1 : CommunityToolkit.Maui.Views.Popup
{
    public u1()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}