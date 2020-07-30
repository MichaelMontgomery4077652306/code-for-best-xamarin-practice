using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Xamarin.Forms;

namespace TruliteMobile.Views
{

    public class MenuItemModel:ObservableObject
    {
        private string _extraInfo;
        private bool _hasExtraInfo;

        public MenuItemModel()
        {
            TargetType = typeof(MasterDetailPage1Detail);
            NotificationBalloonColor = Color.FromHex("#5CB85C");
            SubMenuList= new ObservableCollection<MenuItemModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ImageSource Icon { get; set; }
        public bool IsWebLink { get; set; }
        public string Link { get; set; }
        public Type TargetType { get; set; }
        public string IconText { get; set; }

        public object Tag { get; set; } 

        public Color NotificationBalloonColor { get; set; }


        private ObservableCollection<MenuItemModel> _subMenuList;

        public ObservableCollection<MenuItemModel> SubMenuList
        {
            get { return _subMenuList; }
            set
            {
                _subMenuList = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(HasSubMenu));
            }
        }

        public bool HasSubMenu => _subMenuList?.Any() ?? false;

        public bool IsSeparator { get; set; }

        public bool HasExtraInfo
        {
            get { return _hasExtraInfo; }
            set { _hasExtraInfo = value; }
        }
        
        public string ExtraInfo
        {
            get { return _extraInfo; }
            set { _extraInfo = value; RaisePropertyChanged(); }
        }
    }
}