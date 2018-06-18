using System.Collections.Generic;
using KSapp1.Droid.Model;

namespace KSapp1.Droid.Controller
{
    class Barometr_afterController
    {
        public List<BaromentrAfter> GetBarometrAfter(string receivedString)
        {
            List<BaromentrAfter> BRater = new List<BaromentrAfter>();

            BRater.Add(new BaromentrAfter() { Barometr_after = receivedString });
            return BRater;
        }
    }
}