using UnityEngine;

public class gate2 : MonoBehaviour
{
    public keyscript1 Keyscript1;
    public GameObject gate;
    public Audiomanager audiomanager;
    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Keyscript1.keycount == 1)
        {
            Destroy(gate);
           
        }
       

        else {

            audiomanager.Play("goldenkey");
        }
    }

}
