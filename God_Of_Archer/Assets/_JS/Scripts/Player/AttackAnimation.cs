using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    PlayerAnimatorController animator;
    bool stopDraw = false;

    // Draw �� ���� �ӵ� (1�ʿ� drawAmount�� �󸶳� �ö���)
    [SerializeField] private float pullSpeed = 1f;

    // ���� drawAmount ��
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
