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
    class IrTemp_afterController
    {
        public List<IrTemperatureAfter> GetIrTempAfter(string receivedString)
        {
            List<IrTemperatureAfter> IrTater = new List<IrTemperatureAfter>();

            IrTater.Add(new IrTemperatureAfter() { IrTemperature_after = receivedString });
            return IrTater;
        }
    }
}