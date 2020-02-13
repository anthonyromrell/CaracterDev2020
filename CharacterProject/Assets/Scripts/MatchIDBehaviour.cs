
using System;
using System.Collections.Generic;
using UnityEngine;

public class MatchIDBehaviour : MonoBehaviour
{
    public List<NameID> nameIds;
    private NameID otherIDObj;

    public List<DoWork> DoWorks;
    
    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = GetComponent<IDBehaviour>().nameIDObj;
        CheckID();
    }

    private void CheckID()
    {
        foreach (var obj in nameIds)
        {
            if (obj == otherIDObj)
            {
                foreach (var job in DoWorks)
                {
                    job.Work();
                }
            }
        }
    }
}
