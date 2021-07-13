using UnityEngine;

public class keyscript : MonoBehaviour
{
    public float rotatespeed;
    public int keycount = 0;
    public PlayerController score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotatespeed * Time.deltaTime, 0);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        score.score += 200;
        keycount = 1;
    }

}
