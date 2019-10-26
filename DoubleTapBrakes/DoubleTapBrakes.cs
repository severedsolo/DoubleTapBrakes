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
        private KeyBinding _brakeKey;

        private void Start()
        {
            _brakeKey = GameSettings.BRAKES;
        }

        private void Update()
        {
            if (_brakeKey.GetDoubleTapUp(false)) FlightGlobals.ActiveVessel.ActionGroups.SetGroup(KSPActionGroup.Brakes, true);
        }
    }
}

