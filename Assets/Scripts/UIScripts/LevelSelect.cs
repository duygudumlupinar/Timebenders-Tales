using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] string selectedLevel;

    public void GoToSelectedLevel()
    {
        SceneManager.LoadScene(selectedLevel);
    }
}
