using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo
{
    public interface IUIService : IService
    {
        void RegisterHotkey(string key, string windowKey);
        IEnumerable<string> GetPanelHotkeys();
        void PressedPanelHotkey(string key);
    }
}