using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
