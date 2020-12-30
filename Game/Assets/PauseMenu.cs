using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject mPausepanel;
    bool mIspaused=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && mIspaused == false)
        {
            mIspaused = true;
            mPausepanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && mIspaused == true)
        {
            mIspaused = false;
            mPausepanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void resume()
    {
        mIspaused = false;
        Time.timeScale = 1;
        mPausepanel.SetActive(false);
    }

    public void menu()
    {
        mIspaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
