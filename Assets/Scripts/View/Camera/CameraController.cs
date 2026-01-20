using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Camera realCamera;

    private void Start()
    {
        Game.Do(new RegisterCamera(OnRegistered));
    }

    void OnRegistered(ICameraModel model)
    {
        model.Size.ValueChanged += OnSizeChanged;
    }

    void OnSizeChanged(float oldSize, float newSize)
    {
        realCamera.orthographicSize = newSize;
    }
}
