using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CustomCommandsDemo
{
    public class NameList : INotifyPropertyChanged
    {
        string _firstName = "";
        string _lastName = "";
        string _email = "";
        int phone;

        string _selectedName;

        InfoCommand _infoCommand = new InfoCommand();
        AddCommand _addNameCommand = new AddCommand();
        RemoveCommand _removeNameCommand = new RemoveCommand();

        public NameList()
        {
            List<NameList> user = new List<NameList>();
            Names = new ObservableCollection<string>();
          //  GetUserList = new List<NameList>();
        }
   //     private List<NameList> GetUserList { get; set; }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                }
            }
        }

        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    OnPropertyChanged("SelectedName");
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }


        public ObservableCollection<string> Names { get; private set; }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public InfoCommand InformationCommand
        {
            get { return _infoCommand; }
        }

        public AddCommand AddNameCommand
        {
            get { return _addNameCommand; }
        }

        public RemoveCommand RemoveNameCommand
        {
            get { return _removeNameCommand; }
        }
    }
}
