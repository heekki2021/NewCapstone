using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickHandle : MonoBehaviour
{
    private bool isInRange = false;

    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(ChangeSceneAfterDelay(0.5f));
        }
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TheHandle")  // Replace "YourObjectTag" with your 3D object's tag
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TheHandle")  // Replace "YourObjectTag" with your 3D object's tag
        {
            isInRange = false;
        }
    }
}
