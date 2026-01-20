using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial interface IGameModel
{
    IInputModel Input { get; }
    ITimeModel Time { get; }
}
