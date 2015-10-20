using UnityEngine;
using System.Collections;

public class SoundEffects : MonoBehaviour {

	public AudioClip[] sfxArray;
	
	public void PlaySound(int clip) {

		AudioSource audio = GetComponent<AudioSource> ();
		switch (clip) {
		case 0:
			audio.clip = sfxArray [clip];
			audio.priority = 180;
			audio.Play ();
			break;
		case 1:
			audio.clip = sfxArray [clip];
			audio.priority = 128;
			audio.Play ();
			break;
		case 2:
			audio.clip = sfxArray [clip];
			audio.priority = 128;
			audio.Play ();
			break;
		case 3:
			audio.clip = sfxArray [clip];
			audio.priority = 120;
			audio.Play ();
			break;
		case 4:
			audio.clip = sfxArray [clip];
			audio.priority = 120;
			audio.Play ();
			break;
		case 5:
			audio.clip = sfxArray [clip];
			audio.priority = 120;
			audio.Play ();
			break;
		}
	}
}
