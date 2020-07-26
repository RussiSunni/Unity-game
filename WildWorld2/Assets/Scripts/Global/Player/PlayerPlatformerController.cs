using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject
{

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    Vector2 movement;
    public static GameObject SpellBookUI;



    // Use this for initialization
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        if (Progress.playerCharacter == "English")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character1Animation", typeof(RuntimeAnimatorController));

        else if (Progress.playerCharacter == "Japanese")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character2Animation", typeof(RuntimeAnimatorController));

        else if (Progress.playerCharacter == "North African")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character3Animation", typeof(RuntimeAnimatorController));

        else if (Progress.playerCharacter == "South African")
            animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Animation/Character4Animation", typeof(RuntimeAnimatorController));


        SpellBookUI = GameObject.Find("SpellBookUI");
        SpellBookUI.SetActive(false);
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }

        //   bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        //  if (flipSprite)
        // {
        //    spriteRenderer.flipX = !spriteRenderer.flipX;
        //}

        //   animator.SetBool("grounded", grounded);
        //    animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        targetVelocity = move * maxSpeed;
    }

    public void LoadSpellBookUI()
    {
        if (SpellBookUI.activeSelf)
        {
            SpellBookUI.SetActive(false);
        }
        else
        {
            SpellBookUI.SetActive(true);
        }
    }
}