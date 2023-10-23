using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private float elapsedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= 3f)
            {
                // Load the next scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else
        {
            elapsedTime = 0f;
        }
    }
}