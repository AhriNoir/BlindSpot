using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollide : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");
    }
}
