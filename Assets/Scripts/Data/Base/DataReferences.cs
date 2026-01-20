using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This only exists to create a reference to data objects so they get their OnEnable() called
/// </summary>
[CreateAssetMenu(menuName="Data/Data References")]
public sealed class DataReferences : ScriptableObject
{
    [SerializeField]
    ScriptableObject[] _references;

    private void OnEnable()
    {
        //if(!Application.isPlaying)
        //{
        //    return;
        //}

        foreach(var r in _references)
        {
            if(r is not IRegisteredData rd)
            {
                continue;
            }
            DataService.Register(rd);
        }
    }

    private void OnDisable()
    {
        DataService.Clear();
    }
}
