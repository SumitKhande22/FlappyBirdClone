using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource die;
    public AudioSource jump;
    public AudioSource hit;
    public AudioSource point;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void PlaySound(AudioSource sound){
        sound.Stop();
        sound.Play();

    }
    public void PlayModifiedSound(AudioSource sound)
    {
        sound.pitch = Random.Range(0.8f, 1.2f);
        sound.Stop();
        sound.Play();
    }
   
}
