using UnityEngine;

[CreateAssetMenu]
public class MathFunctions : DoWork
{
    public FloatData dataObj;
    
    public override void Work()
    {
        dataObj.Value++;
    }
}