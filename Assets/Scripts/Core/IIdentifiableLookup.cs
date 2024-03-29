using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IIdentifiableLookup<out TIdentifiable>
    where TIdentifiable : IIdentifiable
{
    event Action<TIdentifiable> AddedItem;
    event Action<TIdentifiable> RemovedItem;
    TIdentifiable this[Guid id] { get; }
    bool IsEmpty { get; }
    bool HasId(Guid id);
    TIdentifiable GetItem(Guid id);
    IEnumerable<TIdentifiable> AllItems { get; }
}
