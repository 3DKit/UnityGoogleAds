using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    private float touchTimeThreshold = 5f; // 5 seconds
    private float currentTouchTime;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Reset the touch time when the touch begins
                currentTouchTime = 0f;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                // Increment touch time when the touch is stationary or moved
                currentTouchTime += Time.deltaTime;

                if (currentTouchTime >= touchTimeThreshold)
                {
                    // Time threshold reached, restart the level
                    RestartLevelFunction();
                }
            }
        }
        else
        {
            // Reset touch time if there is no touch
            currentTouchTime = 0f;
        }
    }

    void RestartLevelFunction()
    {
        // Implement the code to restart the level here
        // For example:
        SceneManager.LoadScene("SampleScene");
    }
}
