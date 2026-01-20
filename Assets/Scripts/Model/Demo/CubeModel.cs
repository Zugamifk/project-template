using System;
using UnityEngine;

public class CubeModel : ICubeModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public float Rotation { get; set; } = 90;

}
