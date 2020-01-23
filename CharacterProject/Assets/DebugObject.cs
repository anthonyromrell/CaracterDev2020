using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class DebugObject : ScriptableObject
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }
}
