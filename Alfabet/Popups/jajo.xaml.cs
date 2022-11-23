using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class jajo : CommunityToolkit.Maui.Views.Popup
{
    public jajo()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}