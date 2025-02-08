using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public int indiceEscena;
    public KeyCode teclaCambio = KeyCode.Space;
    /*public bool cambiarEscena = false;*/

    void Update()
    {
        if (Input.GetKeyDown(teclaCambio) /*|| cambiarEscena*/)
        {
            if (indiceEscena >= 0)
            {
                SceneManager.LoadScene(indiceEscena);
            }
            else
            {
                Debug.LogError("Scene index is invalid!");
            }
        }
    }
}

// Lo que está entre /*---*/ puede representar una mejora en el juego quizá al automatizar el cambio de escena.
// De igual manera tuve problemas para implementar el cambio de escena en el juego de manera automatiza y dado
// que no dispongo de mucho tiempo, decidí hacerlo de esta manera. 