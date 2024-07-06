using UnityEngine;
using System;
using System.Linq;
using System.Reflection;
[CreateAssetMenu(fileName = "PlayerConfig", menuName = "ScriptableObjects/PlayerConfig", order = 1)]
public class PlayerConfig : ScriptableObject
{
    public float maxHp;
    public float moveSpeed;

    public float attackSpeed;
    public float attackRange;
    public float attackDamage;
}