using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

using TruliteMobile.Services;
using TruliteMobile.Misc;
using TruliteMobile.ViewModels;
using TruliteMobile.Models.Directions;

namespace TruliteMobile.Views.DrvManifests
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrvManifestDirectionsMapPage : ContentPage
    {
		private readonly DrvManifestDirectionsMapPageViewModel _viewModel;

		public DrvManifestDirectionsMapPage(IEnumerable<PackingSlip> packingSlips)
        {
			InitializeComponent();
			BindingContext = _viewModel = new DrvManifestDirectionsMapPageViewModel(packingSlips);
			
			_viewModel.Map = map;
			_viewModel.DestPicker = picker;
			picker.SelectedIndexChanged += _viewModel.DestSelectionChanged;
        }
	}

	public class DrvManifestDirectionsMapPageViewModel : TruliteBaseViewModel
	{
		private Location _currentLocation;
		private ObservableCollection<string> _destAddresses;
		public ObservableCollection<string> DestAddresses
		{
			get { return _destAddresses; }
			set { _destAddresses = value;  RaisePropertyChanged(); }
		}

		private Xamarin.Forms.Maps.Map _map;

		public Xamarin.Forms.Maps.Map Map
		{
			get { return _map; }
			set { _map = value; RaisePropertyChanged(); }
		}

		private Picker _destPicker;

		public Picker DestPicker
		{
			get { return _destPicker; }
			set { _destPicker = value; RaisePropertyChanged(); }
		}

		private string _selectedAddress;

		public string SelectedAddress
		{
			get { return _selectedAddress; }
			set { _selectedAddress = value; RaisePropertyChanged(); }
		}

		public DrvManifestDirectionsMapPageViewModel(IEnumerable<PackingSlip> packingSlips)
		{

			var list = new List<string>();
			foreach ( PackingSlip _item in packingSlips )
			{
				list.Add(_item.CustAddress.PackedAddress);
			}
			DestAddresses = new ObservableCollection<string>(list);
			SelectedAddress = list.FirstOrDefault();
			MoveToCurrentLocation();
		}

		public async void DestSelectionChanged(object sender, EventArgs e)
		{
			var _picker = sender as Picker;
			SelectedAddress = _picker.SelectedItem.ToString();

			DrawRoute();
		}

		async void MoveToCurrentLocation()
		{
			_currentLocation = await Geolocation.GetLocationAsync();
			Position _currentPos = new Position(_currentLocation.Latitude, _currentLocation.Longitude);
			_map.MoveToRegion(MapSpan.FromCenterAndRadius(_currentPos, Distance.FromMiles(1)));
			DrawRoute();
		}

		private async void DrawRoute()
		{
			List<Position> _routePositions = await GetDirectionPositions();
			Polyline _polyline = new Polyline
			{
				StrokeColor = Color.Red,
				StrokeWidth = 6,
				Geopath = { }
			};
			foreach (Position _pos in _routePositions)
			{
				_polyline.Geopath.Add(_pos);
			}
			Pin _pinSource = new Pin
			{
				Position = new Position(_currentLocation.Latitude, _currentLocation.Longitude),
				Label = "A"
			};
			Pin _pinDest = new Pin
			{
				Position = _routePositions.LastOrDefault(),
				Label = "B"
			};
			_map.MapElements.Clear();
			_map.Pins.Clear();
			_map.Pins.Add(_pinSource);
			_map.Pins.Add(_pinDest);
			_map.MapElements.Add(_polyline);
		}

		private async Task<List<Position>> GetDirectionPositions()
		{
			Geocoder _geocoder = new Geocoder();
			List<Position> _positions = new List<Position>();
			try
			{
				IEnumerable<Position> _destPositions = await _geocoder.GetPositionsForAddressAsync(SelectedAddress);
				Position _dest = _destPositions.FirstOrDefault();
				string fullDirectionURL = string.Format(Constants.GoogleMapDirectionApiURL, _currentLocation.Latitude.ToString(), _currentLocation.Longitude.ToString(), _dest.Latitude.ToString(), _dest.Longitude.ToString());
				HttpClient client_ = new HttpClient();
				try
				{
					using (var request_ = new System.Net.Http.HttpRequestMessage())
					{
						request_.RequestUri = new System.Uri(fullDirectionURL);
						request_.Method = new System.Net.Http.HttpMethod("GET");
						request_.Headers.Accept.Add(
							System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
						var response_ = await client_.SendAsync(request_,
							System.Net.Http.HttpCompletionOption.ResponseHeadersRead, System.Threading.CancellationToken.None)
							.ConfigureAwait(false);



						{
							var _strResponse = await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
							var _objectResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<DirectionModel>(_strResponse);

							
							if (_objectResponse.routes.Count > 0)
							{
								_positions = DecodePolylinePoints(_objectResponse.routes[0].overview_polyline.points);
							}
						}
					}
				}
				catch (Exception e)
				{
					await Alert.DisplayError(e);
				}
			}
			catch (Exception e)
			{
				await Alert.DisplayError(e);
			}
			return _positions;
		}

		List<Position> DecodePolylinePoints(string encodedPoints)
		{
			if (string.IsNullOrEmpty(encodedPoints))
				return null;
			var poly = new List<Position>();
			char[] polylinechars = encodedPoints.ToCharArray();
			int index = 0;

			int currentLat = 0;
			int currentLng = 0;
			int next5bits;
			int sum;
			int shifter;

			try
			{
				while (index < polylinechars.Length)
				{
					// calculate next latitude
					sum = 0;
					shifter = 0;
					do
					{
						next5bits = (int)polylinechars[index++] - 63;
						sum |= (next5bits & 31) << shifter;
						shifter += 5;
					} while (next5bits >= 32 && index < polylinechars.Length);

					if (index >= polylinechars.Length)
						break;

					currentLat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

					//calculate next longitude
					sum = 0;
					shifter = 0;
					do
					{
						next5bits = (int)polylinechars[index++] - 63;
						sum |= (next5bits & 31) << shifter;
						shifter += 5;
					} while (next5bits >= 32 && index < polylinechars.Length);

					if (index >= polylinechars.Length && next5bits >= 32)
						break;

					currentLng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);
					Position p = new Position(Convert.ToDouble(currentLat) / 100000.0, Convert.ToDouble(currentLng) / 100000.0);
					poly.Add(p);
				}
			}
			catch
			{
			}
			return poly;
		}
	}
}