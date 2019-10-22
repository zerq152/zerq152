using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{

    [SerializeField]
    private float MoveSpeed;

    protected Vector2 Movement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Move();
    }


    public void Move()
    {
        transform.Translate(Movement * MoveSpeed * Time.deltaTime);
    }

}