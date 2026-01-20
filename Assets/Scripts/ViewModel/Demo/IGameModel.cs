using UnityEngine;

public partial interface IGameModel
{
    IUIModel UI { get; }
    IIdentifiableLookup<ICubeModel> Cubes { get; }
}
