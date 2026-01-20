using System;
using System.Collections.Generic;
using UnityEngine;
using Demo;

public partial class GameModel
{
    public UIModel DemoUI { get; } = new();
    public IdentifiableCollection<CubeModel> DemoCubes { get; set; } = new();

    #region IGameModel
    IUIModel IGameModel.DemoUI => DemoUI;
    IIdentifiableLookup<ICubeModel> IGameModel.DemoCubes => DemoCubes;
    #endregion
}
