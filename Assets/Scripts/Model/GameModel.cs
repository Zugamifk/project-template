using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
public class GameModel : IGameModel
{
    public Dictionary<string, Guid> UniqueKeyToId { get; } = new();
    public CameraModel Camera { get; } = new();
    public InputModel Input { get; } = new();
    public UIModel UI { get; } = new();
    public TimeModel TimeModel = new TimeModel();


    #region IGameModel
    ITimeModel IGameModel.Time => TimeModel;
    IInputModel IGameModel.Input => Input;
    IUIModel IGameModel.UI => UI;
    #endregion

}
