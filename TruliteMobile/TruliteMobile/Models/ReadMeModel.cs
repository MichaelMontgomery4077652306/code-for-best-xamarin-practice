using GalaSoft.MvvmLight;

namespace TruliteMobile.Models
{
    public class ReadMeModel : ObservableObject
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                RaisePropertyChanged();
            }
        }

        private int _featureId;

        public int FeatureId
        {
            get { return _featureId; }
            set
            {
                _featureId = value;
                RaisePropertyChanged();
            }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged();
            }
        }
    }
}