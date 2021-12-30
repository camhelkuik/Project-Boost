using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int startingScene = SceneManager.GetActiveScene().buildIndex;
            int firstLevel = startingScene + 1;

            SceneManager.LoadScene(firstLevel);
        }
    }
}
