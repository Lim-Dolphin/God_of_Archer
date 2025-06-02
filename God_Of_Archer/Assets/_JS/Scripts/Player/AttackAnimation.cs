using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    PlayerAnimatorController animator;
    bool stopDraw = false;

    // Draw 중 당기는 속도 (1초에 drawAmount가 얼마나 올라갈지)
    [SerializeField] private float pullSpeed = 1f;

    // 현재 drawAmount 값
    private float currentDraw = 0f;
    void Awake()
    {
        animator = GetComponent<PlayerAnimatorController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.TriggerNock();
            currentDraw = 0f;
            animator.BowState = currentDraw;
        }
        if (Input.GetMouseButton(0) && !stopDraw)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                stopDraw = true;
                animator.TriggerRelease();
            }
            currentDraw += Time.deltaTime * pullSpeed;
            currentDraw = Mathf.Clamp01(currentDraw);
            animator.BowState = currentDraw;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (stopDraw) stopDraw = false;
            currentDraw = 0f;
            animator.BowState = currentDraw;
            animator.TriggerRelease();
        }
    }
}
