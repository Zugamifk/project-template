using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    public interface IUIModel
    {
        IBinding<string> CurrentMessage { get; }
    }
}