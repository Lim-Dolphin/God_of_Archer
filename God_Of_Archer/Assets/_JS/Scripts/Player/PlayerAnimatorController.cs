using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Base Layer(0번 레이어)에서 현재 재생 중인 State 정보를 가져옵니다.
    AnimatorStateInfo stateInfo;
    public AnimatorStateInfo StateInfo => stateInfo;

    private void Start()
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
    }

    public float MoveSpeed
    {
        set => animator.SetFloat("movementSpeed", value);
        get => animator.GetFloat("movementSpeed");
    }

    public float BowState
    {
        set => animator.SetFloat("BowState", value);
        get => animator.GetFloat("BowState");
    }

    public void TriggerJump()
    {
        animator.SetTrigger("Jump");
    }

    public void TriggerNock()
    {
        animator.SetTrigger("Nock");
    }
    public void TriggerRelease()
    {
        animator.SetTrigger("Release");
    }

    public void TriggerHit()
    {
        animator.SetTrigger("Hit");
    }
    public void TriggerDie()
    {
        animator.SetTrigger("Die");
    }

    public void TriggerShoot() 
    {
        animator.SetTrigger("Shoot");
    }
    public void Play(string stateName, int layer, float normalizedTime)
    {
        animator.Play(stateName, layer, normalizedTime);
    }


    // 외부에서 호출할 수 있도록 Spine 본 회전을 래핑해서 노출
    public void SetSpineRotation(Quaternion rot)
    {
        animator.SetBoneLocalRotation(HumanBodyBones.Spine, rot);
    }

    // Head 본 회전도 필요하다면 추가
    public void SetHeadRotation(Quaternion rot)
    {
        animator.SetBoneLocalRotation(HumanBodyBones.Head, rot);
    }
}
