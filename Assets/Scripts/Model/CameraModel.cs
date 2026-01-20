using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraModel : ICameraModel
{
    public Guid Id { get; } = Guid.NewGuid();
    public Guid TargetId { get; set; }
    public Binding<float> Size { get; set; } = new();
    IBinding<float> ICameraModel.Size => Size;
}
