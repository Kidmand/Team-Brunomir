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