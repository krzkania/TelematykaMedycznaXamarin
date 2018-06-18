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
    class Light_beforeController
    {
        public List<LightBefore> GetLightBefores()
        {
            List<LightBefore> lightBefores = new List<LightBefore>();
            lightBefores.Add(new LightBefore() { Light_before = 148.2f });
            return lightBefores;
        }
    }
}