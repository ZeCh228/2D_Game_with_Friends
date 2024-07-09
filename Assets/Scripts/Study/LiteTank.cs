using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


public class LiteTank : Tank 
{
    public override void Shoot()
    {
        Debug.Log("LT_SHOOT");
    }
}