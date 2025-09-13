using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circles : MonoBehaviour
{
    public Transform Target;
    public float Distance;
    private float speed;
    private float angle;

    

    void Start()
    {
        Target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        speed = Distance * .5f;
        angle += speed * Time.deltaTime;

        float x = Target.position.x + Mathf.Cos(angle) * Distance;
        float y = Target.position.y + Mathf.Sin(angle) * Distance;

        transform.position = new Vector2(x, y);
    }
}
