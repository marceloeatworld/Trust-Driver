using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trust_Driver.EventListeners;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Trust_Driver.DataModels
{
    class RideDetails
    {
        public string PickupAddress { get; set; }
        public string DestinationAddress { get; set; }
        public string RiderName { get; set; }
        public string RiderPhone { get; set; }
        public double PickupLat { get; set; }
        public double PickupLng { get; set; }
        public double DestinationLat { get; set; }
        public double DestinationLng { get; set; }
        public string RideId { get; set; }
    }
}
