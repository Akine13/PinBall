using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    private float rotSpeed = 1.0f;
    // Use this for initialization
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
    void OnCollisionEnter(Collision Collision)
    {
        if (tag == "SmallStarTag")
        {
            FindObjectOfType<BallController>().AddPoint(5);
        }
        if (tag == "LargeStarTag")
        {
            FindObjectOfType<BallController>().AddPoint(10);
        }
    }
}
