using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorControllerLight : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private GameObject mirror;
    [SerializeField] private Material flatMaterial;
    [SerializeField] private Material mirrorMaterial;
    [SerializeField] private GameObject endPoint;

    private void OnTriggerEnter(Collider other)
    {
        _light.enabled = false;
        mirror.GetComponent<MeshRenderer>().material = flatMaterial;
        mirror.GetComponent<Collider>().enabled = false;
        endPoint.GetComponent<Collider>().enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _light.enabled = true;
        mirror.GetComponent<MeshRenderer>().material = mirrorMaterial;
        mirror.GetComponent<Collider>().enabled = true;
        endPoint.GetComponent<Collider>().enabled = false;
    }
}
