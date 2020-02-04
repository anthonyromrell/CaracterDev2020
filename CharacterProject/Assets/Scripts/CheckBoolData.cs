using UnityEngine;

public class CheckBoolData : MonoBehaviour
{
    public BoolData boolDataObj;
    // Update is called once per frame
    void Update()
    {
        if (boolDataObj.value)
        {
            print(true);
            //work to do
        }
        else
        {
            //do false work
        }
    }
}
