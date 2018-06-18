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
    class IrTemp_beforeController
    {
        public List<IrTemperatureBefore> GetIrTempBefores()
        {
            List<IrTemperatureBefore> IrTbefore = new List<IrTemperatureBefore>();
            IrTbefore.Add(new IrTemperatureBefore() { IrTemperature_before = 19.2f });
            return IrTbefore;
        }
    }
}