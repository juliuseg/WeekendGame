using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    PlayerStates playerStates;

    public bool LOL;

    private Dictionary<int, string> intAnimations = new Dictionary<int, string>(){
        {0, "WalkUp"}, // up, walk
        {1, "WalkRight"}, // right, walk
        {2, "WalkDown"}, // down, walk
        {3, "WalkLeft"}, // left, walk
        {4,"IdleUp"}, // up, idle
        {5,"IdleRight"}, // right, idle
        {6,"IdleDown"}, // down, idle
        {7,"IdleLeft"}, // left, idle
    };
    public void Initialize(PlayerStates playerStates){
        this.playerStates = playerStates;
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        if (animator == null){
            Debug.LogError("No animator found, please add one");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (playerStates.isWalking){
            switch (playerStates.direction){
                case direction.up:
                    PlayAnimation(0);
                    break;
                case direction.right:
                    PlayAnimation(1);
                    break;
                case direction.down:
                    PlayAnimation(2);
                    break;
                case direction.left:
                    PlayAnimation(3);
                    break;
                
            }
        } else {
            switch (playerStates.direction){
                case direction.up:
                    PlayAnimation(4);
                    break;
                case direction.right:
                    PlayAnimation(5);
                    break;
                case direction.down:
                    PlayAnimation(6);
                    break;
                case direction.left:
                    PlayAnimation(7);
                    break;
            }
        }
    }

    void PlayAnimation(int animation){
        if (intAnimations.ContainsKey(animation))
        {
            if (animator.HasState(0, Animator.StringToHash(intAnimations[animation])))
            {
                animator.Play(intAnimations[animation]);
            } else {
                Debug.LogError("Animator does not have state: " + intAnimations[animation]);
            }
        } else {
            Debug.LogError("Need to add animation name to dictionary");
        }
    }
}
