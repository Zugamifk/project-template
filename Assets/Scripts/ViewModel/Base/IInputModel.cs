using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public interface IInputModel
{
    IBinding<Guid> CurrentInteractable { get; }
    IBinding<Vector2> ClickPosition { get; }
}
