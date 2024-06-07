
using CommunityToolkit.Mvvm.Input;
using FreshVeggies.Models;
using System.Collections.ObjectModel;
using System.Reflection;

namespace FreshVeggies.ViewModels.TabViewModels
{
    public partial class BuyViewModel : BaseViewModel
    {

        [ObservableProperty]
        ObservableCollection<Vegetable> veggies;

        Realm realm;


        private readonly IRealmService realmService;
        public BuyViewModel(IRealmService realmService)
        {
            try
            {
                this.realmService = realmService;
               

                Veggies = new ObservableCollection<Vegetable>(realm.All<Vegetable>());

                //Veggies = new ObservableCollection<Vegetable>();

                //byte[] imageArray = null;
                //Assembly? assembly = Assembly.GetExecutingAssembly();
                //using Stream? stream = assembly.GetManifestResourceStream("FreshVeggies.Resources.Images.beans.jpg");
                //{
                //    if (stream != null)
                //    {
                //        imageArray = new byte[stream.Length];

                //    }
                //};



                //Veggies.Add(new Vegetable(name: "Beans",description: "beans have protein, fiber, iron and vitamins",image:imageArray,price:30,unitOfPrice: 250));
            }
            catch (Exception ex)
            {

               Shell.Current.DisplayAlert("Error", ex.Message, "Ok");
            }
          
        }

        public async Task Initialize()
        {
            try
            {

                Realm realm = Realm.GetInstance();
            }
            catch (Exception ex)
            {

                await Shell.Current.DisplayAlert("Error", ex.Message,"Okay");
            }
        }

        [RelayCommand]
        public async Task VeggieSelected(Vegetable veggie)
        {
            try
            {
                // Handle the selection of a veggie
            }
            catch (Exception ex)
            {

                await Shell.Current.DisplayAlert("Error", ex.Message, "Okay");
            }
            
        }
    }
}
