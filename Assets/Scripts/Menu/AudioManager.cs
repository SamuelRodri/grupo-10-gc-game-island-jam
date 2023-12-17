using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("---- Audio Source ----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource SFXSource_rompiendo;

    [Header ("---- Audio Clic ----")]
    public AudioClip backgroud;
    public AudioClip rodando;
    public AudioClip rompiendo;

    private void Start() {
        musicSource.clip = backgroud;
        SFXSource.clip = rodando;
        SFXSource_rompiendo.clip = rompiendo;

        Invoke("MyFunction", 1.5f);

        musicSource.Play();
        SFXSource.Play();
        
    }

    void MyFunction()
    {
      SFXSource_rompiendo.Play();
    }
     

    private void Awake() {
      DontDestroyOnLoad(gameObject);
    }

    //publid void PlaySFX(AudioClip clip) {
      //  SFXSource.PlayOneShot(clip)
    //}
}
