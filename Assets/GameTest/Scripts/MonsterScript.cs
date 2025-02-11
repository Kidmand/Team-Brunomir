using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public float Speed, JumpForce, LargeRaycast;
    public bool CanMove = false; // Variable para controlar si el monstruo puede moverse.
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float eje_x;
    private bool Grounded;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (CanMove)
        {
            HandleMovementInput();
            HandleJumpInput();
            UpdateAnimator();
            CheckGroundStatus();
        }
    }

    private void FixedUpdate()
    {
        if (CanMove)
        {
            Move();
        }
    }

    // Obtener la entrada del jugador para mover al monstruo.
    private void HandleMovementInput()
    {
        eje_x = Input.GetAxis("Horizontal");
    }

    // Permitir que el monstruo salte si está en el suelo y se presiona la tecla W.
    private void HandleJumpInput()
    {
        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }
    }

    // Actualiza el estado de la animación del monstruo, dependiendo de si nos movemos o no.
    private void UpdateAnimator()
    {
        Animator.SetBool("Running", eje_x != 0.0f);
        UpdateScale();
    }

    // Cambia la animación dependiendo de si nos movemos a la izquierda o derecha.
    private void UpdateScale()
    {
        if (eje_x < 0.0f)
        {
            transform.localScale = new Vector3(-28.6665f, 25.7613f, 1.0f);
        }
        else if (eje_x > 0.0f)
        {
            transform.localScale = new Vector3(28.6665f, 25.7613f, 1.0f);
        }
    }

    // Verificar si el monstruo está en el suelo para poder saltar nuevamente.
    private void CheckGroundStatus()
    {
        Grounded = Physics2D.Raycast(transform.position, Vector3.down, LargeRaycast);
    }

    // Aplicar una fuerza al salto del monstruo.
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    // Definir la velocidad del monstruo sobre el eje x.
    private void Move()
    {
        Rigidbody2D.velocity = new Vector2(eje_x * Speed, Rigidbody2D.velocity.y);
    }
}