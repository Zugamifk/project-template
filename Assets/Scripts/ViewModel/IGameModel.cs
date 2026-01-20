using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameModel
{
    IInputModel Input { get; }
    IUIModel UI { get; }
    ITimeModel Time { get; }
}
