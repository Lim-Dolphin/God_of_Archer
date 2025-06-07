using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArrowName", menuName = "ScriptableObjects/ArrowData", order = 0)]

public class ArrowData : ScriptableObject
{
    [SerializeField] private string arrowName = "Default Arrow";
    [SerializeField] private float arrowDamage = 10f;
    [SerializeField] private bool isGravity = false;
    [SerializeField] private bool isDotDamage = false;
    // 추후 추가: 속도 보정, 이펙트, 상태이상 등

    public string ArrowName => arrowName;
    public float ArrowDamage => arrowDamage;
    public bool IsGravity => isGravity;
    public bool IsDotDamage => isDotDamage;
}
