using UnityEngine;
using UnityEngine.SceneManagement;
public class GameplayButtonController : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
