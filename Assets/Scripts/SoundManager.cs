using System.Diagnostics;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Assign in the Unity Inspector
    public AudioSource audioSource;
    public AudioClip soundEffect;
    // Function for sound to play
    public void PlayerHit(GameObject Pickup)
    {
      //   Debug.Log("Player Hit a collectible object");
        // play sound effect
        audioSource.PlayOneShot(soundEffect);
        Pickup.SetActive(false);
    }
}
