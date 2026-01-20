using System;
using System.Collections.Generic;
using UnityEngine;

public partial class GameModel
{
    public UIModel UI { get; } = new();
    public IdentifiableCollection<CubeModel> Cubes { get; set; } = new();

    #region IGameModel
    IUIModel IGameModel.UI => UI;
    IIdentifiableLookup<ICubeModel> IGameModel.Cubes => Cubes;
    #endregion
}
