using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CustomCommandsDemo
{
    public class AddCommand : ICommand
    {
        public void Execute(object parameter)
        {
            
            var nameList = parameter as NameList;
            var newName = string.Format("{0} {1} {2}", nameList.FirstName, nameList.LastName,nameList.Email);
            nameList.Names.Add(newName);

            List<NameList> user = new List<NameList>();
            user.Add(new NameList
            {
                FirstName = nameList.FirstName,
                LastName = nameList.LastName,
                Email = nameList.Email
            });

            nameList.FirstName = nameList.LastName = "";
        }

        public bool CanExecute(object parameter)
        {
            var nameList = parameter as NameList;
            return nameList != null
                && !string.IsNullOrWhiteSpace(nameList.FirstName)
                && !string.IsNullOrWhiteSpace(nameList.LastName);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
