﻿using UnityEngine;
using System.Collections;

public class GameEventPeoples5 : GameEvent
{

    override public void CheckEvent(int t)
    {
        base.CheckEvent(t);

        if (FindObjectOfType<SpaceShip>().peoples <= 50000) Activate();
    }

    override public void WhenActivate()
    {
        
    }

    override public void LeftButton()
    {
        base.LeftButton();
        FindObjectOfType<SpaceShip>().ChangeHappy(-5);
    }

    override public void RightButton()
    {
        base.RightButton();
        FindObjectOfType<SpaceShip>().ChangeHappy(-5);
    }
}
