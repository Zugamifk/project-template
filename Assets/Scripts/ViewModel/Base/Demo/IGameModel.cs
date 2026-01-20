using UnityEngine;
using Demo;

public partial interface IGameModel
{
    IUIModel DemoUI { get; }
    IIdentifiableLookup<ICubeModel> DemoCubes { get; }
}
