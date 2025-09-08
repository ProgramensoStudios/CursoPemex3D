using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource mainAudio;
    public AudioSource efectsoundAudio;

    public void AddSound()
    {
        mainAudio.volume += 0.001f;
    }

    public void RestSound()
    {
        mainAudio.volume -= 0.001f;
    }

    public void PlaySound(AudioClip clip)
    {
        efectsoundAudio.Stop(); 
        efectsoundAudio.clip = clip;
        efectsoundAudio.Play();
    }
}
