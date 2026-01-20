using System;
using System.Collections.Generic;
using UnityEngine;

public partial class GameModel
{
    public UIModel UI { get; } = new();

    #region IGameModel
    IUIModel IGameModel.UI => UI;
    #endregion
}
