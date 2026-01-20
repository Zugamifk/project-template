using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIModel
{
    IBinding<string> CurrentOpenWindow { get; }
}
