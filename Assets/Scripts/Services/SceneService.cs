using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : IService
{
    const string GAME_SCENE_NAME = "Game";

    [RuntimeInitializeOnLoadMethod]
    public static void LoadCoreScenes()
    {
        LoadIfUnloaded(GAME_SCENE_NAME);

        // LOAD ADDITIONAL REQUIRED SCENES HERE
    }
    static void LoadIfUnloaded(string sceneName)
    {
        if (!SceneManager.GetSceneByName(sceneName).isLoaded)
        {
            SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        }
    }
}
