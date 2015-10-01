using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XOGame.Annotations;

namespace XOGame.ViewModel
{
    class GamePageViewModel: INotifyPropertyChanged
    {
        private bool? _field1;

        public bool? Field1
        {
            get { return _field1; }
            set
            {
                if (value == _field1) return;
                _field1 = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public GamePageViewModel()
        {
                
        }
    }
}
