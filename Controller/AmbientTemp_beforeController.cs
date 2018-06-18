using System.Collections.Generic;
using KSapp1.Droid.Model;

namespace KSapp1.Droid.Controller
{
    class AmbientTemp_beforeController
    {
        public List<AmbientTemperatureBefore> GetAmbientTemperatureBefores()
        {
             List<AmbientTemperatureBefore> ATbefore = new List<AmbientTemperatureBefore>();
            
            ATbefore.Add(new AmbientTemperatureBefore() { AmbientTemperature_before=27.1f });
            return ATbefore;
        }
    }
}