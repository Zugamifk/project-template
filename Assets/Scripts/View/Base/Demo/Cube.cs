using UnityEngine;

public class Cube : ModelViewBase<ICubeModel>
{
    public override ICubeModel GetModel() => Game.Model.Cubes.GetItem(Id);

    public override void InitializeFromModel(ICubeModel model)
    {
    }

    void Update()
    {
        var m = GetModel();
        transform.Rotate(0,m.Rotation*Time.deltaTime,0);
    }
}
