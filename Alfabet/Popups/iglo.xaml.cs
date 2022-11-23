using CommunityToolkit.Maui.Views;
namespace Alfabet;

public partial class iglo : CommunityToolkit.Maui.Views.Popup
{
    public iglo()
    {
        InitializeComponent();
    }

    void OnImageClicked(object? sender, EventArgs e) => Close();
}