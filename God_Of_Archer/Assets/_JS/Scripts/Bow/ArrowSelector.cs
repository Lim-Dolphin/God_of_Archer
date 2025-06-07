using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSelector : MonoBehaviour
{
    
    // Current Arrow(인터페이스 타입 선언)
    [HideInInspector] public ArrowData arrowData;

    [Header("Arrow Data Presets")]
    [SerializeField] private ArrowData defaultArrow;
    [SerializeField] private ArrowData straightArrow;
    [SerializeField] private ArrowData dotDamageArrow;

    void Start()
    {
        arrowData = defaultArrow;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            arrowData = defaultArrow;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            arrowData = straightArrow;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            arrowData = dotDamageArrow;
        }
        
    }
}
