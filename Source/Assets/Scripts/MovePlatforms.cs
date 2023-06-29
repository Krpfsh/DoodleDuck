using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlatforms : MonoBehaviour
{
    float speed = 3f;
    bool moveingRight = true;
    private float ran ;
    private void Start()
    {
        ran = Random.Range(0, 2.4f);
    }
    private void Update()
    {

        if (transform.position.x > ran)
        {
            moveingRight = false;

        }
        else if (transform.position.x < -ran)
        {
            moveingRight = true;

        }

        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        }
    }
}
