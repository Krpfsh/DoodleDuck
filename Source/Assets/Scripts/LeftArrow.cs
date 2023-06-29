using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : MonoBehaviour
{
    //public GameObject player;
    private Rigidbody2D player;
    public float speed;
    public float horizontalSpeed;
    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        
        player.velocity = new Vector2(speed,player.velocity.y);
    }
}
