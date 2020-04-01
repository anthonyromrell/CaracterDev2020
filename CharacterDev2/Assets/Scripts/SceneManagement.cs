using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneManagement : ScriptableObject
{
    private string currentName;
    
    public void LoadScene (Object scene)
    {
        currentName = scene.name;
        Debug.Log(currentName);
        SceneManager.LoadScene(currentName);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadScene (string byName)
    {
        SceneManager.LoadScene(byName);
    }
}