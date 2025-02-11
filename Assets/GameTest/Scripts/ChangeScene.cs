using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int indexScene;
    public KeyCode keyCode = KeyCode.Space;
    public bool changeScene = false;

    void Update()
    {
        if (Input.GetKeyDown(keyCode) || changeScene)
        {
            ChangeSceneByIndex(indexScene);
        }
    }

    public static void ChangeSceneByIndex(int index)
    {
        if (index >= 0)
        {
            SceneManager.LoadScene(index);
        }
        else
        {
            Debug.LogError("Scene index is invalid!");
        }
    }
}

// Lo que está entre /*---*/ puede representar una mejora en el juego quizá al automatizar el cambio de escena.
// De igual manera tuve problemas para implementar el cambio de escena en el juego de manera automatizada y dado
// que no dispongo de mucho tiempo, decidí hacerlo de esta manera. 