using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class AudioButton1 : MonoBehaviour
{
    public AudioClip audioClip;
    private Button button;
    private AudioSource audioSource;

    private void Start()
    {
        // Mendapatkan referensi komponen Button pada game object ini
        button = GetComponent<Button>();

        // Mendapatkan atau menambahkan komponen AudioSource pada game object ini
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Menetapkan audio clip pada AudioSource
        audioSource.clip = audioClip;

        // Menambahkan listener ke event OnClick dari Button
        button.onClick.AddListener(PlayAudio);
    }

    private void PlayAudio()
    {
        // Memainkan audio clip
        audioSource.PlayOneShot(audioClip);
    }
}
