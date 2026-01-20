using UnityEngine;

public class StartDemo : ICommand
{
    public void Execute(GameModel model)
    {
        Game.Do(new SpawnCube());
        Game.Do(new SpawnCube());
        Game.Do(new SpawnCube());
        Game.Do(new SpawnCube());
        Game.Do(new SpawnCube());
    }
}
