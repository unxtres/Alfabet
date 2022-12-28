using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class u3 : CommunityToolkit.Maui.Views.Popup
{
    public u3()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}