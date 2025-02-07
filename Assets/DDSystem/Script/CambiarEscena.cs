using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public int indiceEscena;
    public KeyCode teclaCambio = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(teclaCambio))
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