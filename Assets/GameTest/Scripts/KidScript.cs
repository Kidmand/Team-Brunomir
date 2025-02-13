using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class KidScript : MonoBehaviour
{
    public GameObject Monster;
    private Animator Animator;
    private bool IsDead = false;
    private float localScaleX, localScaleY;
    private const float DeadKid = 50;
    private const float ScaleThreshold = 200;


    private void Start()
    {
        Animator = GetComponent<Animator>();
        localScaleX = transform.localScale.x;
        localScaleY = transform.localScale.y;
    }

    private void Update()
    {
        Vector3 direction = GetDirectionToMonster();
        UpdateScale(direction);
        CheckIfDead(direction);
    }

    // Retorna la distancia que hay entre el niño y el monstruo.
    private Vector3 GetDirectionToMonster()
    {
        return transform.position - Monster.transform.position;
    }

    // Actualiza la escala del niño dependiendo de la dirección en la que se encuentre el monstruo.
    // Esto sirve para que el niño mire hacia el monstruo cuando este esté a una determinada distancia.
    // Cuando el monstruo mata al niño, se desactiva esta opción.
    // La variable KidDead se utiliza para activar la animación de muerte del niño. Es decir, cambiar de estado.
    private void UpdateScale(Vector3 direction)
    {   
        if (!Animator.GetBool("KidDead") && !IsDead)
        {
            if (direction.x >= ScaleThreshold || direction.x <= 0)
                transform.localScale = new Vector3(localScaleX, localScaleY, 1f);
            else if (direction.x < ScaleThreshold && direction.x > 0)
                transform.localScale = new Vector3(-localScaleX, localScaleY, 1f);
        }
    }

    // Verificar si el niño está muerto. La variable IsDead se utiliza para evitar que el niño
    // siga girando su posición al monstruo cuando ya está muerto.
    private void CheckIfDead(Vector3 direction)
    {
        if (Mathf.Abs(direction.x) <=  DeadKid && Input.GetKeyDown(KeyCode.F))
        {
            Animator.SetBool("KidDead", true);
            IsDead = true;
        }
        else if (Mathf.Abs(direction.x) >  DeadKid && Input.GetKeyDown(KeyCode.F))
        {
            Animator.SetBool("KidDead", false);
        }
    }
}