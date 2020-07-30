using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TruliteMobile.Components;
using TruliteMobile.i18n;
using TruliteMobile.Misc;
using TruliteMobile.Models;
using TruliteMobile.Services;
using TruliteMobile.ViewModels;
using TruliteMobile.Views.Quotes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinUniversity.Infrastructure;

namespace TruliteMobile.Views.Orders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDateChangesPage : ContentPage
    {
        private readonly ViewDateChangesPageViewModel _vm;

        public ViewDateChangesPage(SalesOrder order)
        {
            InitializeComponent();
            BindingContext = _vm = new ViewDateChangesPageViewModel(order);
        }

        protected override async void OnAppearing()
        {
            await _vm.Load();
        }
    }

    public class ViewDateChangesPageViewModel : TruliteBaseViewModel
    {

        #region Properties and Fields
        private SortColumnItem _selectedSortColumn;

        public SortColumnItem SelectedSortColumn
        {
            get { return _selectedSortColumn; }
            set
            {
                _selectedSortColumn = value;
                RaisePropertyChanged();
            }
        }

        private bool _ascending;

        public bool Ascending
        {
            get { return _ascending; }
            set
            {
                _ascending = value;
                RaisePropertyChanged();
            }
        }
        public ObservableCollection<SortColumnItem> SortColumns
        {
            get { return _sortColumns; }
            set
            {
                _sortColumns = value;
                RaisePropertyChanged();
            }
        }



        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }


        private readonly SalesOrder _order;
        private string _title;
        private ObservableCollection<CfmDlvDateTracking> _dateChangesList;
        private ObservableCollection<SortColumnItem> _sortColumns;

        public ObservableCollection<CfmDlvDateTracking> DateChangesList
        {
            get { return _dateChangesList; }
            set
            {
                _dateChangesList = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public ICommand FilterTriggeredCommand { get; }

        public ViewDateChangesPageViewModel(SalesOrder order)
        {
            _order = order;
            FilterTriggeredCommand = new Command<SortColumnItem>(OnFilterTriggered);
            Title = $"{nameof(AppResources.DateChangesFor).Translate()} {order.Key}";
            SortColumns = new ObservableCollection<SortColumnItem>
            {
                new SortColumnItem(DateChangesSortColumns.LineNumber, nameof(AppResources.LineNumber).Translate()),
                new SortColumnItem(DateChangesSortColumns.OldDeliveryDate, nameof(AppResources.OldDeliveryDate).Translate()),
                new SortColumnItem(DateChangesSortColumns.NewDeliveryDate, nameof(AppResources.NewDeliveryDate).Translate()),
                new SortColumnItem(DateChangesSortColumns.CreatedBy, nameof(AppResources.CreatedBy).Translate()),
                new SortColumnItem(DateChangesSortColumns.Reason, nameof(AppResources.Reason).Translate()),
            };
            Ascending = true;
            SelectedSortColumn = _sortColumns[0];
        }

        private void OnFilterTriggered(SortColumnItem sortOrder)
        {
            DateChangesList = new ObservableCollection<CfmDlvDateTracking>(SortList(sortOrder, _dateChangesList));
        }

        private IEnumerable<CfmDlvDateTracking> SortList(SortColumnItem sortOrder, ICollection<CfmDlvDateTracking> listToSort)
        {
            if (!(listToSort?.Any() ?? false))
            {
                return new List<CfmDlvDateTracking>();
            }

            IEnumerable<CfmDlvDateTracking> sortedList = null;
            switch (sortOrder.Key.ObjectToEnum<DateChangesSortColumns>())
            {
                case DateChangesSortColumns.LineNumber:
                    sortedList = sortOrder.Ascending
                        ? listToSort.OrderBy(p => p.LineNum).ToList()
                        : listToSort.OrderByDescending(p => p.LineNum).ToList();
                    break;
                case DateChangesSortColumns.OldDeliveryDate:
                    sortedList = sortOrder.Ascending
                        ? listToSort.OrderBy(p => p.OldDeliveryDate.GetValueOrDefault()).ToList()
                        : listToSort.OrderByDescending(p => p.OldDeliveryDate.GetValueOrDefault()).ToList();
                    break;
                case DateChangesSortColumns.NewDeliveryDate:
                    sortedList = sortOrder.Ascending
                        ? listToSort.OrderBy(p => p.NewDeliveryDate.GetValueOrDefault()).ToList()
                        : listToSort.OrderByDescending(p => p.NewDeliveryDate.GetValueOrDefault()).ToList();
                    break;
                case DateChangesSortColumns.CreatedBy:
                    sortedList = sortOrder.Ascending
                        ? listToSort.OrderBy(p => p.CreatedBy).ToList()
                        : listToSort.OrderByDescending(p => p.CreatedBy).ToList();
                    break;
                case DateChangesSortColumns.Reason:
                    sortedList = sortOrder.Ascending
                        ? listToSort.OrderBy(p => p.ReasonCode).ToList()
                        : listToSort.OrderByDescending(p => p.ReasonCode).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return sortedList;
        }

        public async Task Load()
        {
            try
            {
                IsBusy = true;
                var result = await Api.GetOrderDateTrackingByOrder(_order.Key);

                if (!result.Successful.GetValueOrDefault())
                {
                    await Alert.DisplayApiCallError(result.ExceptionMessage, result.ValidationErrors);
                    return;
                }
                DateChangesList = new ObservableCollection<CfmDlvDateTracking>(SortList(new SortColumnItem
                {
                    Ascending = _ascending,
                    Key = _selectedSortColumn.Key
                }, result.Data));
                NoResults = !_dateChangesList.Any();
            }
            catch (Exception e)
            {
                await Alert.DisplayError(e);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }

    public enum DateChangesSortColumns
    {
        LineNumber,
        OldDeliveryDate,
        NewDeliveryDate,
        CreatedBy,
        Reason
    }
}