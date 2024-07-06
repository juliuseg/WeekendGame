using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private HealthManager healthManager;

    private PlayerAnimation playerAnimation;
    private PlayerShooting playerShooting;

    [SerializeField]
    private PlayerConfig playerConfig;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStates playerStates = new PlayerStates();

        playerAnimation = GetComponent<PlayerAnimation>();
        playerAnimation.Initialize(playerStates);

        playerShooting = GetComponent<PlayerShooting>();
        playerShooting.Initialize(playerStates, playerConfig.attackSpeed, playerConfig.attackRange, playerConfig.attackDamage);

        playerMovement = GetComponent<PlayerMovement>();
        playerMovement.Initialize(playerConfig.moveSpeed, playerStates);

        healthManager = GetComponent<HealthManager>();
        healthManager.Initialize(playerConfig.maxHp);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
