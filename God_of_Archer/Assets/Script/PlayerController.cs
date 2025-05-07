using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip audioClipWalk;
    [SerializeField] 
    private AudioClip audioClipRun;


    private RotateCamera _rotateCamera;
    private MovementCharacterController _movementCharacterController;
    private Status status;
    private PlayerAnimatorController animator;
    private AudioSource audioSource;
    private Bow bow;
    private bool onBow = false;


    private void Awake()
    {
        //마우스 커서를 보이지 않게 설정하고 현재 위치에 고정
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        _rotateCamera = GetComponent<RotateCamera>();
        _movementCharacterController = GetComponent<MovementCharacterController>();
        status = GetComponent<Status>();
        animator = GetComponent<PlayerAnimatorController>();    
        audioSource = GetComponent<AudioSource>();
        bow = GetComponentInChildren<Bow>();
    } 

    // Update is called once per frame
    void Update()
    {
        UpdateRotate();
        UpdateMove();
        UpdateJump();
        UpdateBowAction();
    }

    private void UpdateRotate()
    {
        float cameraX = Input.GetAxis("Mouse X");
        float cameraY = Input.GetAxis("Mouse Y");

        _rotateCamera.UpdateRotate(cameraX, cameraY);
    }

    private void UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        //이동 중 일 떼 (걷기 or 뛰기)
        if(x != 0 || z != 0)
        {
            bool isRun = false;
            //옆이나 뒤로 이동할 때는 달릴 수 없다
            if (z > 0) isRun = (Input.GetAxisRaw("Run") == 1);

            _movementCharacterController.MoveSpeed = (isRun == true) ? status.RunSpeed : status.WalkSpeed;
            animator.MoveSpeed = (isRun == true) ? 1 : 0.5f;
            audioSource.clip = (isRun == true) ? audioClipRun : audioClipWalk;

            if(audioSource.isPlaying == false)
            {
                audioSource.loop = true;
                audioSource.Play();
            }
        }
        else
        {
            _movementCharacterController.MoveSpeed = 0;
            animator.MoveSpeed = 0;
            if(audioSource.isPlaying == true)
            {
                audioSource.Stop();
            }
        }

        _movementCharacterController.MoveTo(new Vector3(x,0,z));
    }

    private void UpdateJump() 
    {
        if(Input.GetButtonDown("Jump"))
        {
            _movementCharacterController.Jump();
        }
    }

    private void UpdateBowAction()
    {
       
        bow.StartBowAction(Input.GetAxisRaw("Attack"));
    }
}
