using System;
using GalaSoft.MvvmLight;

namespace TruliteMobile.Views.Notifications
{
    public class NotificationModel:ObservableObject
    {
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

        private string _status;

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _executed;

        public DateTime Executed
        {
            get { return _executed; }
            set
            {
                _executed = value;
                RaisePropertyChanged();
            }
        }

        private TimeSpan _duration;

        public TimeSpan Duration
        {
            get { return _duration; }
            set
            {
                _duration = value;
                RaisePropertyChanged();
            }
        }
         
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged();
            }
        }
    }
}