using UnityEngine;
using UnityEngine.UI;

public class endstoryscript : MonoBehaviour
{
    public GameObject firstline;
    public Button next;
    private int count;
    public Audiomanager audiomanager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        firstline.SetActive(true);
        next.gameObject.SetActive(true);
        audiomanager.Play("bgmgame");
    }
}
