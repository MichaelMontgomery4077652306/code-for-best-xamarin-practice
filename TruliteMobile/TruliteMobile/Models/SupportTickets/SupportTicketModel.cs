using System;
using GalaSoft.MvvmLight;
using TruliteMobile.Enums;

namespace TruliteMobile.Views.SupportTickets
{
    public class SupportTicketModel : ObservableObject
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }

        private SupportTicketStatusEnum _status;

        public SupportTicketStatusEnum Status
        {
            get { return _status; }
            set
            {
                _status = value;
                RaisePropertyChanged();
            }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                RaisePropertyChanged();
            }
        }

        private string _contact;

        public string Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _lastUpdated;

        public DateTime LastUpdated
        {
            get { return _lastUpdated; }
            set
            {
                _lastUpdated = value;
                RaisePropertyChanged();
            }
        }

        private string _supportRep;

        public string SupportRep
        {
            get { return _supportRep; }
            set
            {
                _supportRep = value;
                RaisePropertyChanged();
            }
        }


        private SupportTicketPriorityEnum _priority;

        public SupportTicketPriorityEnum Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                RaisePropertyChanged();
            }
        }

    }


}