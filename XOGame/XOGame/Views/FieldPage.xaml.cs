using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XOGame.Views
{
    public partial class FieldPage : ContentPage
    {
        public FieldPage()
        {
            InitializeComponent();
            BindingContext = new FieldPage();
        }
    }
}
