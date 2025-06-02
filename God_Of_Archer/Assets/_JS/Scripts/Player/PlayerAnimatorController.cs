using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    // Base Layer(0�� ���̾�)���� ���� ��� ���� State ������ �����ɴϴ�.
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


    // �ܺο��� ȣ���� �� �ֵ��� Spine �� ȸ���� �����ؼ� ����
    public void SetSpineRotation(Quaternion rot)
    {
        animator.SetBoneLocalRotation(HumanBodyBones.Spine, rot);
    }

    // Head �� ȸ���� �ʿ��ϴٸ� �߰�
    public void SetHeadRotation(Quaternion rot)
    {
        animator.SetBoneLocalRotation(HumanBodyBones.Head, rot);
    }
}
