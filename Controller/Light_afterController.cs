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
    class Light_afterController
    {
        public List<LightAfter> GetLightAfter(string receivedString)
        {
            List<LightAfter> LTater = new List<LightAfter>();

            LTater.Add(new LightAfter() { Light_after = receivedString });
            return LTater;
        }

    }
}