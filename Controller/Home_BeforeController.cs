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
using KSapp1.Droid.Controller;
using KSapp1.Droid.Model;

namespace KSapp1.Droid.Controller
{
    class Home_BeforeController
    {
        public Home_BeforeController()
        {
            GetATB();
            //GetBBC();
            GetHBC();
            GetITB();
        }
        public Object GetATB()
        {
            AmbientTemp_beforeController ambientTemp_BeforeController = new AmbientTemp_beforeController();
            return (ambientTemp_BeforeController.GetAmbientTemperatureBefores());

            //ambientTemp_BeforeController.GetAmbientTemperatureBefores();
            //ATbefore.Add(new AmbientTemperatureBefore() { AmbientTemperature_before = 27.1f });

            //return (ambientTemp_BeforeController);
            //return (ambientTemp_BeforeController.GetAmbientTemperatureBefores());
        }
        //public List<Barometr_beforeController> GetBBC()
        //{
        //    Barometr_beforeController barometr_BeforeController = new Barometr_beforeController();
        //    return (barometr_BeforeController.GetBarometrBefores());
        //}
        public Object GetHBC()
        {
            Humadity_beforeController humadity_BeforeController = new Humadity_beforeController();
            return (humadity_BeforeController.GetHumadityBefores());
        }
        public Object GetITB()
        {
            IrTemp_beforeController irTemp_BeforeController = new IrTemp_beforeController();
            return (irTemp_BeforeController.GetIrTempBefores());
        }

    }
}