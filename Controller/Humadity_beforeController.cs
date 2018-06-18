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
    class Humadity_beforeController
    {
        public List<HumadityBefore> GetHumadityBefores()
        {
            List<HumadityBefore> HMbefore = new List<HumadityBefore>();
            HMbefore.Add(new HumadityBefore() { Humadity_before = 72.8f });
            return HMbefore;
        }
    }
}