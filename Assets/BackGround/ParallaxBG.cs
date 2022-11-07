using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBG : MonoBehaviour
{
    private BoxCollider2D boxCollier;
    private Rigidbody2D rigid;
    private float Height;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        boxCollier = GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();
        Height = boxCollier.size.y;
        rigid.velocity = new Vector2(0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10) Reposition();
    }
    private void Reposition()
    {
        Vector2 vector = new Vector2(0, 10);
        transform.position = (Vector2)transform.position + vector;
    }
}
