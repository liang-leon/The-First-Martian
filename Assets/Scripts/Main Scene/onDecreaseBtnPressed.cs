﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDecreaseBtnPressed : MonoBehaviour {
    public void Button_Clicked ()
    {
        if (State.noOfAstronauts != 0 && !Replay.replayQuery)
        {
            State.noOfAstronauts--;
        }
        
    }
}
