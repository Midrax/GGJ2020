﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstants
{
    public enum StationType {
        //LWelding,
        LElectric,
        LProgramming,
        //HDisassembly,
        HWiring,
        HWelding,
        CPolishing,
        CTable,
        CInspection,
        CBoxGenerator,
        CBoxSlot
    }

    public enum PlayerBotType
    {
        Light,
        Heavy
    }
    
    public enum ButtonMessage
    {
        Special1Pressed, // Can Handle sensitivity later
        Special2Pressed, // same
        SprintPressed // Regular true or flase value
    }

    public enum JoystickControlMessage
    {
        MoveJoystick
    }

    public enum StationAnimations
    {
        BoxInput,
        BoxOutput,
        Working,
        Idle
    }
    public enum RobotAnimations
    {
        BoxInput,
        BoxOutput,
        Working,
        Idle
    }
}
