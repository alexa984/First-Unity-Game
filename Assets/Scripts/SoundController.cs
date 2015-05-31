using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour {

AudioSource fxSound; 
 public AudioClip backMusic; 
 void Start ()
     
 {
     this.fxSound = this.GetComponent<AudioSource>();
     fxSound = GetComponent<AudioSource> ();
     fxSound.Play ();
 }
}
