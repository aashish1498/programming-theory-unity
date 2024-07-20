using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    protected float scale = 1.0f;
    protected float speed = 10.0f;
    protected int score = 1;

    private MainManager mainManager;
    private Rigidbody rb;


    private void OnEnable()
    {
        mainManager = MainManager.Instance;
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
    }

    void FixedUpdate()
    {
        Move();
    }

    protected virtual void Move()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    public void OnHit()
    {
        mainManager.AddToScore(score);
        Destroy(gameObject);
    }
}
