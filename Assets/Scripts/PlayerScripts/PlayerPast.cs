using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPast : MonoBehaviour
{    
    public void PlayTheRecord(List<Vector3> positions)
    {
        if (positions.Count > 0)
        {
            transform.position = positions[positions.Count - 1];
            positions.RemoveAt(positions.Count - 1);
        }
    }
}
