using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioSource [] mAudioFiles;

    private void Awake()
    {
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
