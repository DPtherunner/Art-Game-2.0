using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevels : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Application.Quit();
    }
}
