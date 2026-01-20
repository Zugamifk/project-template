using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIModel : IUIModel
{
    public Binding<string> CurrentOpenWindow { get; } = new();
    IBinding<string> IUIModel.CurrentOpenWindow => CurrentOpenWindow;
}
