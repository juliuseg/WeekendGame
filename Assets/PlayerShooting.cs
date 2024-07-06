using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    private PlayerStates playerStates;

    private float attackSpeed;
    private float attackRange;
    private float attackDamage;


    public void Initialize(PlayerStates playerStates, float attackSpeed, float attackRange, float attackDamage)
    {
        this.playerStates = playerStates;
        this.attackSpeed = attackSpeed;
        this.attackRange = attackRange;
        this.attackDamage = attackDamage;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
