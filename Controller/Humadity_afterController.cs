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
    class Humadity_afterController
    {
        public List<HumadityAfter> GetHumadityAfter(string receivedString)
        {
            List<HumadityAfter> HMater = new List<HumadityAfter>();

            HMater.Add(new HumadityAfter() { Humadity_after = receivedString });
            return HMater;
        }
    }
}