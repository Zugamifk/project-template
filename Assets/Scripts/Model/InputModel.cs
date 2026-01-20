using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class InputModel : IInputModel
{
    public HashSet<Guid> InteractableTargets { get; set; } = new();
    public Binding<Guid> CurrentInteractable { get; set; } = new();
    public Binding<Vector2> ClickPosition { get; set; } = new();
    IBinding<Guid> IInputModel.CurrentInteractable => CurrentInteractable;

    IBinding<Vector2> IInputModel.ClickPosition => ClickPosition;
}
