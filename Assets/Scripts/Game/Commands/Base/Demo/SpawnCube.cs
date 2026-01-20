using UnityEngine;

namespace Demo
{
    public class SpawnCube : ICommand
    {
        public void Execute(GameModel model)
        {
            var cube = new CubeModel();
            cube.Rotation = Random.Range(-180, 180);
            model.DemoCubes.AddItem(cube);
        }
    }
}