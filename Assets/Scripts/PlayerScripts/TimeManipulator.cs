using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class TimeManipulator : MonoBehaviour
{
    [SerializeField] GameObject pastVersion;
    [SerializeField] Light globalLight;
    private bool isManipulatable = true;
    private bool isPresent = true;
    private bool isRecording = false;
    private List<Vector3> movements = new List<Vector3>();
    private Animator lightAnimator;

    private void Start()
    {
        lightAnimator = globalLight.GetComponent<Animator>();
    }

    void Update()
    {
        //T starts time manipulation
        //Can only go back once, isManipulatable checks it
        if (Input.GetKeyDown(KeyCode.T) && isManipulatable)
        {
            isPresent = false;
            isRecording = false;
            pastVersion.SetActive(true);
            lightAnimator.SetTrigger("ToPast");
            isManipulatable = false;
        }
        //Actions in the present time are recorded
        if (Input.GetKeyDown(KeyCode.R) && isPresent)
        {
            lightAnimator.SetTrigger("Recording");
            isRecording = true;
        }
        if (isRecording)
        {
            movements.Insert(0, transform.position);
        }        
        //Record is played to rewind the past
        if (!isPresent)
        {
            pastVersion.GetComponent<PlayerPast>().PlayTheRecord(movements);
        }
    }

    public void ResetTimeManipulation()
    {
        isManipulatable = true;
        isPresent = true;
        isRecording = false;
        movements.Clear();
        pastVersion.SetActive(false);
        lightAnimator.SetTrigger("Restart");
    }
}
