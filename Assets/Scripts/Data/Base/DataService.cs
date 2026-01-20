using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataService
{
    static Dictionary<System.Type, IRegisteredData> _dataTypeToCollection = new Dictionary<System.Type, IRegisteredData>();

    internal static void Register<T>(T collection) where T : IRegisteredData
    {
        _dataTypeToCollection[collection.GetType()] = collection;
    }

    internal static void Clear()
    {
        _dataTypeToCollection.Clear();
    }

    public static T GetData<T>() where T : IRegisteredData
    {
        return (T)_dataTypeToCollection[typeof(T)];
    }
}
