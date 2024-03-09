using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelResetter : MonoBehaviour
{
    [SerializeField] Transform startingPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(RestartTheGame(collision.gameObject));
        }
    }

    public void RestartFromTheMenu()
    {
        StartCoroutine(RestartTheGame( GameObject.FindGameObjectWithTag("Player") ));
    }

    IEnumerator RestartTheGame(GameObject player)
    {
        yield return new WaitForSeconds(1);
        player.transform.position = startingPoint.position;
        player.gameObject.GetComponent<TimeManipulator>().ResetTimeManipulation();
    }
}
