using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class SecondSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript, ChangeSceneScript2;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/size:down/Bueno, ahora estamos en mi cuarto y quiero relajarme pero no se que hacer. Voy a pensar en algunas opciones.", "Dante"));

        // Añadir opciones de selección. 
        var selectionText = new DialogData("Creo que estoy entre dos cosas que me harían relajarme bastante.", "Dante");
        selectionText.SelectList.Add("Naturaleza", "Tengo ganas de sentir aire fresco, quizá pueda ir al parque.");
        selectionText.SelectList.Add("Juego", "Tengo muchas ganas de jugar videojuegos, ya que estoy en mi cuarto.");
        selectionText.Callback = () => HandleSelection();
        dialogTexts.Add(selectionText);

        DialogManager.Show(dialogTexts);

    }

    private void HandleSelection()
    {
        var dialogTexts = new List<DialogData>();

        if (DialogManager.Result == "Naturaleza")
        {
            dialogTexts.Add(new DialogData("/emote:Happy/¡Gracias por la idea! /wait:0.1//emote:Normal/Me iré al parque a disfrutar de la naturaleza.", "Dante"));
            DialogManager.Show(dialogTexts);
            StartCoroutine(SceneChanger.WaitAndChangeScene(DialogManager, ChangeSceneScript));
            
        }
        else if (DialogManager.Result == "Juego")
        {
            dialogTexts.Add(new DialogData("/emote:Happy/¡Gracias por la idea! /wait:0.1//emote:Normal/Me quedaré en mi cuarto a disfrutar de los videojuegos.", "Dante"));
            DialogManager.Show(dialogTexts);
            StartCoroutine(SceneChanger.WaitAndChangeScene(DialogManager, ChangeSceneScript2));
        }
    }
}
