using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioSource [] mAudioFiles;
    public static AudioManager mInstance;

    private void Awake()
    {
        if (mInstance == null)
        {
            mInstance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        mAudioFiles = GetComponents<AudioSource>();
        Debug.Log(mAudioFiles[1].name);
    }

    public static void PlayAudioFile(int audioNum)
    {
        mAudioFiles[audioNum].Play();
    }
}
