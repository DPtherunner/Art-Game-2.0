using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    string Level = "";
    void OnTriggerEnter2D(Collider2D other)
    {
        Application.Quit();
    }
}
