using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DoubleTapBrakes
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class DoubleTapBrakes : MonoBehaviour
    {
        KeyBinding brakeKey;

        private void Start()
        {
            brakeKey = GameSettings.BRAKES;
        }

        private void Update()
        {
            if (brakeKey.GetDoubleTapUp(false)) FlightGlobals.ActiveVessel.ActionGroups.SetGroup(KSPActionGroup.Brakes, true);
        }
    }
}

