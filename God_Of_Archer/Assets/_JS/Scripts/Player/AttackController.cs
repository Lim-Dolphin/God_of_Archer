using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip drawSound;
    [SerializeField]
    private AudioClip shootSound;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private PlayerAnimatorController animator;

    [SerializeField] private PlayerStatus status;

    // Update is called once per frame
    void Update()
    {
        if (animator.MoveSpeed > 0.5f || status.CurrentStamina == 0f)
        {
            animator.BowState = 0;
            //if (audioSource.isPlaying) audioSource.Stop();
            return;
        }
        else
        {
            Debug.Log("¾ßÈ£!");
            //if (animator.BowState == 0 && Input.GetMouseButton(0)) { PlaySound(null);}

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("shoot");
                PlaySound(shootSound);
            }

            if (animator.BowState > 0.1f)
            {
                PlaySound(drawSound);
            }
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource.clip == clip) { return; }
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
