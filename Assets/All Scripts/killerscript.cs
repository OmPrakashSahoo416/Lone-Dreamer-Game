using UnityEngine;
using UnityEngine.SceneManagement;

public class killerscript : MonoBehaviour
{
    public GameObject player;
    public bool iskilled;
    

        private void OnCollisionEnter2D(Collision2D collision)
        {
            iskilled = true;
        
        }

        
    


}
