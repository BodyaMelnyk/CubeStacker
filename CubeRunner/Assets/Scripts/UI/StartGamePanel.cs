using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGamePanel : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
        }
    }


}
