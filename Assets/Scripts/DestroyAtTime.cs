using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtTime : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }
}
