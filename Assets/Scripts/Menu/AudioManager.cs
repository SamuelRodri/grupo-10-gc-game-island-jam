using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("---- Audio Source ----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header ("---- Audio Clic ----")]
    public AudioClip backgroud;
    public AudioClip death;

    private void Start() {
        musicSource.clip = backgroud;
        musicSource.Play();
    }

    //publid void PlaySFX(AudioClip clip) {
      //  SFXSource.PlayOneShot(clip)
    //}
}
