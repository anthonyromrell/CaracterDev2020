using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Utilities/Game LevelLoader")]
public class LevelLoader : ScriptableObject
{
    [SerializeField] public SceneAsset scene;
    public string sceneName;
    private void OnEnable()
    {
        sceneName = scene.name;
    }
    
    public enum LoadTypes
    {
        LoadScene,
        LoadSceneAdditive,
        LoadSceneAsync
    }

    public LoadTypes loadType;

    public void Load()
    {
        switch (loadType)
        {
            case LoadTypes.LoadScene:
                SceneManager.LoadScene(sceneName);
                break;
            case LoadTypes.LoadSceneAsync:
                SceneManager.LoadSceneAsync(sceneName);
                break;
            case LoadTypes.LoadSceneAdditive:
                SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
                break;
        }
    }
}