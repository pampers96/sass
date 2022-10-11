using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mballl : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rigib;
    void Start()
    {
        AddStartForce();
    }

    private void Awake()
    {
        rigib = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
    public void ResetPosition()
    {
        rigib.position = Vector3.zero;
        rigib.velocity = Vector3.zero;
    }
    public void AddStartForce()
    {
        float x;
        if(Random.value<0.5f)
        {
            x = -1f;
        }
        else
        {
            x = 1;
        }
        float y;
        y = Random.value<0.5f ? Random.Range(-1, 0.5f) : Random.Range(0.5f, 1);

        Vector2 directio = new Vector2(x, y);
        rigib.AddForce(directio * speed);

    }
}
