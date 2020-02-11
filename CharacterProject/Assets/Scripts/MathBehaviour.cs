using System;
using UnityEngine;

public class MathBehaviour : MonoBehaviour
{
    public FloatData dataObj;
    public FloatData[] floatDataList;
    private NameID otherNameID;
    
    private void OnTriggerEnter(Collider other)
    {
        otherNameID = other.GetComponent<BehaviourID>().nameIdObj;
        ChangeValue();
    }
    
    public void ChangeValue ()
    {
        foreach (var data in floatDataList)
        {
            if (data == otherNameID)
            {
                dataObj.UpdateValue(data.Value);
            }
        }
    }
}