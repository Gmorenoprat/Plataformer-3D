﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPot : Collectable
{
    public int pwr = 1;
    public override void DarStats(Collider other)
    {
      //  other.gameObject.GetComponent<IPotionGrabber>().GetPwr(this.pwr);

    }
}
