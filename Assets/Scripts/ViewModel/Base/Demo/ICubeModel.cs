using UnityEngine;

namespace Demo
{
    public interface ICubeModel : IIdentifiable
    {
        float Rotation { get; }
    }
}