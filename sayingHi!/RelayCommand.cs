using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sayingHi_
{
    class RelayCommand : ICommand 
    {
        private Action<object> message;

        public RelayCommand(Action<object> message)
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            this.message = message;

        }


        public void Execute(object parameter)
        {
            this.message(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                
            }
            remove
            {

            }
        }
  

    }
}
