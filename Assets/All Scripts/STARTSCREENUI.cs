using UnityEngine;
using UnityEngine.SceneManagement;

public class STARTSCREENUI : MonoBehaviour
{
    public void playbutton() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void gameoverrestart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void mainmenu()
    {

        SceneManager.LoadScene("Start Screen");
    }

    public void quit()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }
    public void pausemenu()
    {
        Time.timeScale = 0f;
    }
    public void resumeMenu() {
        Time.timeScale = 1f;
    }
}
