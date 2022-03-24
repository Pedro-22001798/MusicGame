using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTest : MonoBehaviour
{
    [SerializeField] private GameObject[] Note;
    [SerializeField] private float _Time = 10f;
    [SerializeField] private Rigidbody2D[] rb;

    // Start is called before the first frame update
    void Start()
    {
        rb[0].gravityScale = 0;
        rb[1].gravityScale = 0;
        rb[2].gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(_Time > 0)
        {
            _Time -= Time.deltaTime;
        }
        if(_Time < 8)
        {
            rb[0].gravityScale = 1;
        }
        if(_Time < 5)
        {
            rb[1].gravityScale = 1;
        }
        if(_Time < 2)
        {
            rb[2].gravityScale = 1;
        }
    }
}
