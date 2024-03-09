using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettings : MonoBehaviour
{
    public Animator transparentBgAnim, mainBgAnim, secondBgAnim, restartButtonAnim, resumeButtonAnim, musicButtonAnim, mainMenuButtonAnim;
    public Button pauseButton;

    public void Pause()
    {
        pauseButton.enabled = false;
        
        transparentBgAnim.SetBool("Paused", true);
        mainBgAnim.SetBool("Paused", true);
        secondBgAnim.SetBool("Paused", true);
        restartButtonAnim.SetBool("Paused", true);
        resumeButtonAnim.SetBool("Paused", true);
        musicButtonAnim.SetBool("Paused", true);
        mainMenuButtonAnim.SetBool("Paused", true);
        
        StartCoroutine(StopTheGame());
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseButton.enabled = true;

        transparentBgAnim.SetBool("Paused", false);
        mainBgAnim.SetBool("Paused", false);
        secondBgAnim.SetBool("Paused", false);
        restartButtonAnim.SetBool("Paused", false);
        resumeButtonAnim.SetBool("Paused", false);
        musicButtonAnim.SetBool("Paused", false);
        mainMenuButtonAnim.SetBool("Paused", false);
    }

    IEnumerator StopTheGame()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
    }
}
