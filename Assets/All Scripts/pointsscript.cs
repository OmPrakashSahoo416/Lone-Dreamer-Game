
using UnityEngine;

public class pointsscript : MonoBehaviour
{
    public Transform point;
    public GameObject points;
    public float rotatespeed;
   

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        Destroy(points);
        
    }


    void Update()
    {
        point.Rotate(0, rotatespeed * Time.deltaTime, 0);
    }
    
}
