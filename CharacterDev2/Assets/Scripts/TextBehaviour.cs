using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;
    public UnityEvent awakeEvent;
    public StringData data;
    void Start()
    {
        textObj = GetComponent<Text>();
        awakeEvent.Invoke();
    }

    public void Update ()
    {
        textObj.text = data.value;
    }
    
}