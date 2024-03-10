using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(GoToLevelSelectionScreen());
        }
    }

    IEnumerator GoToLevelSelectionScreen()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SampleScene");
    }
}
