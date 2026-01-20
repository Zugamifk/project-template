using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public interface IInputModel
{
    IBinding<Vector2> ClickPosition { get; }
}
