using UnityEngine;

public class CubeViewSpawner : ViewSpawner<ICubeModel, Cube>
{
    [SerializeField]
    Cube prefab;

    protected override IIdentifiableLookup<ICubeModel> collection => Game.Model.Cubes;

    protected override GameObject InstantiateView(ICubeModel model)
    {
        var c = Instantiate(prefab);
        c.transform.position = Random.onUnitSphere * (1 + Random.value*2);
        return c.gameObject;
    }
}
