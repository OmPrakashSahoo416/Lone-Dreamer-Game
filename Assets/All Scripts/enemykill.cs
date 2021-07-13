using UnityEngine;

public class enemykill : MonoBehaviour
{
    public Transform enemyposition;
    public Vector3 offset;
    public GameObject enemy;
    public PlayerController scorepoint;
    public Audiomanager audiomanager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(enemy);
        audiomanager.Play("enemydeath");
        Destroy(gameObject);
        scorepoint.score += 50;
    }

    void Update()
    {
        transform.position = enemyposition.position + offset;
    }
      
}
