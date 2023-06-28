using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PlayPauseButton : MonoBehaviour
{
    public AudioSource audioSource;
    public Sprite playSprite;
    public Sprite pauseSprite;

    private Button button;
    private Image buttonImage;
    private bool isPlaying;

    private void Start()
    {
        // Mendapatkan referensi komponen Button pada game object ini
        button = GetComponent<Button>();

        // Mendapatkan referensi komponen Image pada game object ini
        buttonImage = GetComponent<Image>();

        // Menambahkan listener ke event OnClick dari Button
        button.onClick.AddListener(OnButtonClick);

        // Menginisialisasi status awal
        isPlaying = false;
        SetButtonImage();
    }

    private void OnButtonClick()
    {
        if (isPlaying)
        {
            // Jika sedang bermain, jeda audio
            audioSource.Pause();
        }
        else
        {
            // Jika sedang jeda, mainkan audio
            audioSource.Play();
        }

        // Mengubah status isPlaying dan mengatur tampilan tombol
        isPlaying = !isPlaying;
        SetButtonImage();
    }

    private void SetButtonImage()
    {
        // Mengubah sprite tombol berdasarkan status isPlaying
        buttonImage.sprite = isPlaying ? pauseSprite : playSprite;
    }
}

