using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioClip buttonSound;
    public void click()
    {
        SoundManager.instance.SFXPlay("button", buttonSound);
        //GetComponent<AudioSource>().PlayOneShot(buttonSound);
    }
}
