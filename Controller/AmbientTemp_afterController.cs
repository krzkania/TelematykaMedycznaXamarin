using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using KSapp1.Droid.Model;


namespace KSapp1.Droid.Controller
{
    class AmbientTemp_afterController
    {
        public List<AmbientTemperatureAfter> GetAmbientTemperatureAfter(string receivedString)
        {
            List<AmbientTemperatureAfter> ATater = new List<AmbientTemperatureAfter>();

            ATater.Add(new AmbientTemperatureAfter() { AmbientTemperature_after = receivedString });
            return ATater;
        }
    }
}