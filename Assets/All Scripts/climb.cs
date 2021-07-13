
using UnityEngine;

public class climb : MonoBehaviour
{
    public float speed;
    public float vertical;
    public bool isladder, isclimbing;
    public Rigidbody2D rbplayer;

    private void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (isladder && Mathf.Abs(vertical) > 0f) {
            isclimbing = true;
        }
    }
    private void FixedUpdate()
    {
        if (isclimbing)
        {
            rbplayer.gravityScale = 0f;
            rbplayer.velocity = new Vector2(rbplayer.velocity.x, vertical * speed);
        }
        else {
            rbplayer.gravityScale = 5f;
        }
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject) {
            isladder = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject)
        {
            isladder = false;
            isclimbing = false;
        }
    }

}
