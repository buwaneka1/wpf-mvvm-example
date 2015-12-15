using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;

namespace sayingHi_
{
    class SayingHiViewModel : INotifyPropertyChanged
    {
        private ICommand sayHiButton;
        string hiLabelContent;
        string displayedImage;
         public SayingHiViewModel()
        {
            sayHiButton = new RelayCommand(ShowOnLabel);
            HiLabelContent = "I'll be just a label";
        }

        public string SayHiButtonContent
        {
            get { return "Click me!"; }
           
        }
        public string HiLabelContent
        {
            get { return hiLabelContent; }

            set
            {
                if (this.hiLabelContent == value)
                    return;

                this.hiLabelContent = value;
                NotifyPropertyChanged("HiLabelContent");
            }
        }
       
        public string DisplayedImage
        {
            get { return displayedImage; }

            set
            {
                if (this.displayedImage == value)
                    return;

                this.displayedImage = value;
                NotifyPropertyChanged("DisplayedImage");
            }
        }

        public void ShowOnLabel(object obj)
        {
            HiLabelContent = "Hello How are you?";
            DisplayedImage = "Images/flower.png";
        }

        public ICommand SayHiButton
        {
            get { return sayHiButton; }
            set { sayHiButton = value; }
        }

        public event  PropertyChangedEventHandler PropertyChanged;

            void NotifyPropertyChanged(string propertyName){
                PropertyChangedEventHandler handler = PropertyChanged;
                if(handler != null)
                {
                    handler(this,new PropertyChangedEventArgs(propertyName));
                }
            }
    

        }


    }

