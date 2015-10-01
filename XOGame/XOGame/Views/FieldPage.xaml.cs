using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XOGame.ViewModel;

namespace XOGame.Views
{
    public partial class FieldPage : ContentPage
    {
        private event Action<string> _notifyWinner;

        public FieldPage()
        {
            InitializeComponent();
            _notifyWinner += FieldPage__notifyWinner1;
            BindingContext = new GamePageViewModel(_notifyWinner);
        }

        async private void FieldPage__notifyWinner1(string obj)
        {
            await DisplayAlert("Winners", obj, "Ok", "Cancel");
        }

 
    }
}
