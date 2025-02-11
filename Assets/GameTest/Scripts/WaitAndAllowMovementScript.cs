using System.Collections;
using UnityEngine;
using Doublsb.Dialog;

public static class WaitAndAllowMovement
{
    public static IEnumerator WaitDialog(DialogManager dialogManager, MonsterScript monsterScript, bool CanMove)
    {
        // Esperar a que todos los diálogos terminen.
        while (dialogManager.state != State.Deactivate)
        {
            yield return null;
        }

        // Activar el movimiento del monstruo.
        monsterScript.CanMove = CanMove;
    }
}