using UnityEngine;

public class gateopenscript : MonoBehaviour
{
    public keyscript Keyscript;
    public GameObject gate;
    public Audiomanager audiomanager;
    
    // Start is called before the first frame update
    void Start()
    {
       // Keyscript.name = "keycount";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Keyscript.keycount == 1)
        {
            Destroy(gate);
        }


        else
        {
            if (collision.gameObject.tag == "Player" && Keyscript.keycount == 0)
            { 
                audiomanager.Play("redkey");
            }
        }
    }

}
