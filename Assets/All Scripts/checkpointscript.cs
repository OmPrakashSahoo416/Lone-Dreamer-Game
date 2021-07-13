using UnityEngine;

public class checkpointscript : MonoBehaviour
{
    public Transform checkpoint;
    public killerscript Killerscript;
    public Transform player;
  

    // Update is called once per frame
    void Update()
    {
        if (Killerscript.iskilled == true) {
            player.position = checkpoint.position;
            Killerscript.iskilled = false;
        }
       
    }
   
}
