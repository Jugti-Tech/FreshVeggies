
namespace FreshVeggies.Pages;

public class BasePage : ContentPage
{
	public BasePage(BaseViewModel viewModel)
	{
		Padding=new Thickness(10);	


		BindingContext = viewModel;
	}
}