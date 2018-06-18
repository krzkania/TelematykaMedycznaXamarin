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
    class Barometr_beforeController
    {
        public List<BarometrBefore> GetBarometrBefores()
        {
            List<BarometrBefore> BRbefore = new List<BarometrBefore>();
            BRbefore.Add(new BarometrBefore() { Barometr_before = 1006.7f });
            return BRbefore;
        }
    }
}