using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class NinethSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript;

    private void Awake()
    {   
        var dialogTexts = new List<DialogData>();

        // Nuevamente Dante y Kidmand en el living.
        dialogTexts.Add(new DialogData("/emote:Happy/Hola Kidmand, ¿Qué tal todo?.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Happy/Hola Dante, me da gusto verte... /wait:0.1/Pues un poco aburrido a decir verdad, no se bien que quiero hacer.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Happy/Creo que tengo la solución a tu aburrimiento. ¿Quieres acompañarme al parque y luego vamos al bosque?." , "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/¿No te has enterado Dante?.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Normal/¿Enterado de qué?.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Mataron a un niño en el bosque hace unas horas.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Normal//speed:down/Esta historia continurá.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Normal/Muchas gracias al equipo de TeamBrunomir por darme esta oportunidad. Les mando un enorme saludo.", "Dante"));

        DialogManager.Show(dialogTexts);

        StartCoroutine(WaitAndChangeScene.WaitDialog(DialogManager, ChangeSceneScript));
    }
}

/*
Se que para la escena 9 no uso el cambio de esena automático, pero le dejo el código por si el día de mañana sigo la implementación.
De igual manera está descativado directamente desde Unity, así que esta sería la última escena de una rama de la histoia.
*/