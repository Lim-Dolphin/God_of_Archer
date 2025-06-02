using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AttackController : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField]
    private AudioClip drawSound;
    [SerializeField]
    private AudioClip shootSound;
    [SerializeField] private AudioSource audioSource;

    [Header("Audio Mixer Groups")]
    [SerializeField] private AudioMixerGroup drawMixerGroup;
    [SerializeField] private AudioMixerGroup shootMixerGroup;

    [SerializeField] private PlayerAnimatorController animator;

    [SerializeField] private PlayerStatus status;

    // Update is called once per frame
    void Update()
    {
        if (animator.MoveSpeed > 0.5f || status.CurrentStamina == 0f)
        {
            animator.BowState = 0;
            audioSource.Stop();
            return;
        }
        else
        { 
            if (Input.GetMouseButtonUp(0))
            {
                PlaySound(shootSound, shootMixerGroup);
            }

            if (animator.BowState > 0.1f)
            {
                PlaySound(drawSound, drawMixerGroup);
            }
        }
    }

    private void PlaySound(AudioClip clip, AudioMixerGroup group)
    {
        if (audioSource.clip == clip) { return; }
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.outputAudioMixerGroup = group;
        audioSource.Play();
    }
}
