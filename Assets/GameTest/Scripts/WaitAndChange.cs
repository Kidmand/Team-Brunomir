using System.Collections;
using UnityEngine;
using Doublsb.Dialog;

public static class WaitAndChangeScene
{
    public static IEnumerator WaitDialog(DialogManager dialogManager, ChangeScene changeScenaScript)
    {
        // Esperar a que todos los diálogos terminen.
        while (dialogManager.state != State.Deactivate)
        {
            yield return null;
        }

        // Activar el cambio de escena.
        changeScenaScript.changeScene = true;
    }
}