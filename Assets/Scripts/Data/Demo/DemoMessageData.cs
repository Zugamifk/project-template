using UnityEngine;

namespace Demo
{
    public class DemoMessageData : ScriptableObject, IRegisteredData
    {
        [SerializeField]
        public string[] Messages;
    }
}
