using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidScript : MonoBehaviour
{
    public GameObject Monster;
    private Animator Animator;
    private bool IsDead = false;

    private void Start()
    {
        Animator = GetComponent<Animator>();
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

    // Actualiza la escala del niño dependiendo de la dirección en la que se encuentre el mostruo.
    // Esto sirve para que el niño mire hacia el monstruo cuando este esté a una determinada distancia.
    // Cuando el monstruo mata al niño, se desactiva esta opción.
    // La variable KidDead se utiliza para activar la animación de muerte del niño. Es decir, cambiar de estado.
    private void UpdateScale(Vector3 direction)
    {   
        if (!Animator.GetBool("KidDead") && !IsDead)
        {
            if (direction.x >= 200)
                transform.localScale = new Vector3(62.3790398f, 49.0409698f, 1f);
            else
                transform.localScale = new Vector3(-62.3790398f, 49.0409698f, 1f);
        }
    }

    // Verificar si el niño está muerto. La variable IsDead se utiliza para evitar que el niño
    // siga mirando al monstruo cuando ya está muerto.
    private void CheckIfDead(Vector3 direction)
    {
        if (direction.x <= 30f)
        {
            Animator.SetBool("KidDead", true);
            IsDead = true;
        }
        else
        {
            Animator.SetBool("KidDead", false);
        }
    }
}

/*
    En la función UpdateScale, la parte donde usamos la asiganción de Vector3 para la escala del niño,
    es mucho más prolijo declarar una variable que tenga el valor de transform.localScale.x en lugar de 
    poner el valor numérico directamente, pero esto último me daba un error en la animación. 
*/
