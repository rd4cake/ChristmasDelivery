using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonController : MonoBehaviour
{
   public void LoadGameplayScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
