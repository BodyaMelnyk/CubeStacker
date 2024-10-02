using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
