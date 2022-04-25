using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpeed : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;

    void FixedUpdate()
    {
        transform.position += (-transform.up) * speed * Time.deltaTime;
    }
}
