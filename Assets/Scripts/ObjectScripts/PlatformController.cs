using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject platformA;
    [SerializeField] GameObject platformB;

    private void OnTriggerStay(Collider collision)
    {
        platformA.SetActive(false);
        platformB.SetActive(true);
    }

    private void OnTriggerExit(Collider collision)
    {
        platformA.SetActive(true);
        platformB.SetActive(false);
    }
}
