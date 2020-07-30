using System;
using GalaSoft.MvvmLight;

namespace TruliteMobile.Views.Documents
{
    public class DocumentModel : ObservableObject
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        private string _createdBy;

        public string CreatedBy
        {
            get { return _createdBy; }
            set
            {
                _createdBy = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _createdDate;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                _createdDate = value;
                RaisePropertyChanged();
            }
        }

        private string _link;

        public string Link
        {
            get { return _link; }
            set
            {
                _link = value;
                RaisePropertyChanged();
            }
        }
    }
}