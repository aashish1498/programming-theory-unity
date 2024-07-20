using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Target : MonoBehaviour
{
    protected float scale = 1.0f;
    protected float speed = 10.0f;
    protected int score = 2;

    protected Rigidbody rb;
    private MainManager mainManager;


    protected virtual void OnEnable()
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
        DestoyIfOutOfBounds();
    }

    protected virtual void Move()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    private void OnMouseDown()
    {
        mainManager.AddToScore(score);
        Destroy(gameObject);
    }

    private void DestoyIfOutOfBounds() // ABSTRACTION
    {
        if (transform.position.x > 15.0f)
        {
            Destroy(gameObject);
            mainManager.Reload();
        }
    }
}
