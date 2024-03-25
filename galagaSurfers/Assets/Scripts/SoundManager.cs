using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance;

    public AudioSource sfxSoundSource;

    [SerializeField] private float defaultVolume = 0.5f;


    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        SetSfxVolume(GetUiVolume());
    }


    #region UI SOUND SOURCE

    public void PlaySfxSound(AudioClip soundClip)
    {
        sfxSoundSource.PlayOneShot(soundClip);
    }

    public void SetSfxVolume(float value)
    {
        PlayerPrefs.SetFloat("SfxVolume", value);
        PlayerPrefs.Save();
    }

    public float GetUiVolume()
    {
        return PlayerPrefs.GetFloat("SfxVolume", defaultVolume);
    }
    #endregion

}
