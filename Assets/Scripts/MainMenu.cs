using UnityEngine;
using UnityEngine.SceneManagement;

//Raycastly

public class play_button : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
