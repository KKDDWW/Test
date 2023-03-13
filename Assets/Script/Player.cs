using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;

    public Vector3 dir;

    Animator pAni;
    Rigidbody2D pRig;
    SpriteRenderer sp;

    void Start()
    {
        pAni= GetComponent<Animator>(); 
        pRig = GetComponent<Rigidbody2D>();
        dir = Vector2.zero;
        sp = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
