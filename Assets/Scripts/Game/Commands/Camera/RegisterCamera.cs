using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterCamera : ICommand
{
    Action<ICameraModel> onRegistered;

    public RegisterCamera(Action<ICameraModel> onRegistered)
    {
        this.onRegistered = onRegistered;
    }

    public void Execute(GameModel model)
    {
        model.Camera.Size.Value = 4.5f;

        onRegistered?.Invoke(model.Camera);
    }
}
