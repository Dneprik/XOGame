using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XOGame.Annotations;

namespace XOGame.ViewModel
{
    class GamePageViewModel: INotifyPropertyChanged
    {

        private bool?[] _masField =new bool?[] {null,null,null, null, null, null , null, null, null };
        private bool _whoStep;
        private readonly string _xImage = "X.png";
        private readonly string _oImage = "O.png";

        private Action<string> _notifyWinner;

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public GamePageViewModel(Action<string> NotifyWinner)
        {
                MakeStepCommand=new Command(MakeStep);
                _whoStep = true;//X start first;
            _notifyWinner = NotifyWinner;

        }

        private void MakeStep(object obj)
        {
            int clickedField = Convert.ToInt32(obj);
            if (_masField[clickedField] == null)
            {

                if (_whoStep)
                {
                    AddImage(clickedField,_xImage);
                    _whoStep = false;
                    _masField[clickedField] = true;
                }
                else
                {
                    AddImage(clickedField, _oImage);
                    _whoStep = true;
                    _masField[clickedField] = false;
                }


            }
            VerifyWinners();
        }

        private void VerifyWinners()
        {
            int result = 0;// -1 - O | +1 = X

            //X
            if (_masField[0]==true&&_masField[1]==true&&_masField[2]==true)
            result = 1;
            if (_masField[0] == true && _masField[4] == true && _masField[8] == true)
            result = 1;
            if (_masField[0] == true && _masField[3] == true && _masField[6] == true)
                result = 1;

            if (_masField[2] == true && _masField[4] == true && _masField[6] == true)
                result = 1;
            if (_masField[2] == true && _masField[5] == true && _masField[8] == true)
                result = 1;

            if (_masField[6] == true && _masField[7] == true && _masField[8] == true)
                result = 1;



            //O
            if (_masField[0] == false && _masField[1] == false && _masField[2] == false)
                result = -1;
            if (_masField[0] == false && _masField[4] == false && _masField[8] == false)
                result = -1;
            if (_masField[0] == false && _masField[3] == false && _masField[6] == false)
                result = -1;

            if (_masField[2] == false && _masField[4] == false && _masField[6] == false)
                result = 0;
            if (_masField[2] == false && _masField[5] == false && _masField[8] == false)
                result = -1;

            if (_masField[6] == false && _masField[7] == false && _masField[8] == false)
                result = -1;


            if (result == 1) { if (_notifyWinner!=null) _notifyWinner("X - winners");}
            if (result == -1) { if (_notifyWinner != null) _notifyWinner("O - winners");}

        }


        private void AddImage(int prop, string img)
        {
            switch (prop)
            {
                case 0:
                    ImgField1 = img;break;
                case 1:
                    ImgField2 = img; break;
                case 2:
                    ImgField3 = img; break;
                case 3:
                    ImgField4 = img; break;
                case 4:
                    ImgField5 = img; break;
                case 5:
                    ImgField6 = img; break;
                case 6:
                    ImgField7 = img; break;
                case 7:
                    ImgField8 = img; break;
                case 8:
                    ImgField9 = img; break;

            }

        }



        public ICommand MakeStepCommand { get; }




        //Binding properties
        private string _imgField1;
        private string _imgField2;
        private string _imgField3;
        private string _imgField4;
        private string _imgField5;
        private string _imgField6;
        private string _imgField7;
        private string _imgField8;
        private string _imgField9;

        public string ImgField1
        {
            get { return _imgField1; }
            set
            {
                if (value == _imgField1) return;
                _imgField1 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField2
        {
            get { return _imgField2; }
            set
            {
                if (value == _imgField2) return;
                _imgField2 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField3
        {
            get { return _imgField3; }
            set
            {
                if (value == _imgField3) return;
                _imgField3 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField4
        {
            get { return _imgField4; }
            set
            {
                if (value == _imgField4) return;
                _imgField4 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField5
        {
            get { return _imgField5; }
            set
            {
                if (value == _imgField5) return;
                _imgField5 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField6
        {
            get { return _imgField6; }
            set
            {
                if (value == _imgField6) return;
                _imgField6 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField7
        {
            get { return _imgField7; }
            set
            {
                if (value == _imgField7) return;
                _imgField7 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField8
        {
            get { return _imgField8; }
            set
            {
                if (value == _imgField8) return;
                _imgField8 = value;
                OnPropertyChanged();
            }
        }

        public string ImgField9
        {
            get { return _imgField9; }
            set
            {
                if (value == _imgField9) return;
                _imgField9 = value;
                OnPropertyChanged();
            }
        }

    }
}
