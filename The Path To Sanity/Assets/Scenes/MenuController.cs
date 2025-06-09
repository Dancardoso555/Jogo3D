using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MenuController : MonoBehaviour 
{


    public VideoPlayer videoPlayer;
    public GameObject menuOpcoes, rawImage;
    private Animator animatorRawImage;
    public AudioSource selectSound;





    void Start()
    {
        rawImage.SetActive(false);
        animatorRawImage = rawImage.GetComponent<Animator>();
    }


    void Update()
    {
        if (!videoPlayer.isPlaying && Input.anyKeyDown)
        {
            selectSound.Play();
            videoPlayer.Play();
            animatorRawImage.SetTrigger("fadeIn");
            rawImage.SetActive(true);
            menuOpcoes.SetActive(true);
        }
    }

}


