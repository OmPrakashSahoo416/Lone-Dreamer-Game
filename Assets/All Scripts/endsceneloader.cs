using UnityEngine;
using UnityEngine.SceneManagement;
public class endsceneloader : MonoBehaviour
{
    public Canvas enscenescore,scorecanvas;
    public Audiomanager audiomanager;
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player") {
            Destroy(gameObject);
            enscenescore.gameObject.SetActive(true);
            audiomanager.Play("gamewin");
            scorecanvas.gameObject.SetActive(false);
            
        }
    }
    public void nextbutton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
