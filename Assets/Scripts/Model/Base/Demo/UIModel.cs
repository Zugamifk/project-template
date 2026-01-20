using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIModel : IUIModel
{
    public int CurrentMessageIndex { get; set; } = -1;
    public Binding<string> CurrentMessage { get; } = new();
    IBinding<string> IUIModel.CurrentMessage => CurrentMessage;
}
