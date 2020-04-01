using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    private string currentName;
    
    public void LoadScene (Object scene)
    {
        Debug.Log(scene);
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
