using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class FirstSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Happy//size:up/Hola, /size:init/mi nombre es.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Happy/Hola Dante, yo soy Kidmand. Encantado de conocerte!", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Happy/ El placer es mío.", "Dante"));
        dialogTexts.Add(new DialogData("Hay algo de lo que quiero hablarte Kidmand, quizá te resulte anormal pero considero que es muy importante saberlo.", "Dante"));
        dialogTexts.Add(new DialogData("Oh! Por supuesto Dante, estoy curioso de saber de que se trata. Adelante, dime. ", "Kidmand"));
        dialogTexts.Add(new DialogData("Tu consideras que el desarrollo personal es algo importante en nuestras vidas.", "Dante"));

        // Añadir opciones de selección
        var selectionText = new DialogData("/size:down/Veamos querido lector si conoces a un famoso líder de desarrollo personal llamado Brian Tracy. En unos de sus maravillosos cursos (El seminario Fénix) dice una frase la cúal es:", "Li");
        selectionText.SelectList.Add("Correct","Jamás, jamás, jamás se den por vencidos.");
        selectionText.SelectList.Add("Incorrect1","Lo que la mente del hombre puede concebir y creer, puede lograrse.");
        selectionText.SelectList.Add("Incorrect2","El éxito es una cuestión de motivación, creencias y acostumbrarse a la acción.");
        selectionText.Callback = () => HandleSelection();
        dialogTexts.Add(selectionText);

        DialogManager.Show(dialogTexts);
    }

    private void HandleSelection()
    {
        var dialogTexts = new List<DialogData>();

        if (DialogManager.Result == "Correct")
        {
            dialogTexts.Add(new DialogData("/emote:Happy/Felicitaciones, tienes una excelente memoria al recordar la frase correctamente o tiene suerte por haber adivinado ;).", "Dante"));
        }
        else if (DialogManager.Result == "Incorrect1")
        {
            dialogTexts.Add(new DialogData("/emote:Sad//size:down/Incorrecto, la frase fue dicha por el escritor Napoleón Hill (1883-1970). Uno de los autores de autoayuda y superación más prestigioso del mundo. ", "Dante"));
        }
        else if (DialogManager.Result == "Incorrect2")
        {
            dialogTexts.Add(new DialogData("/emote:Sad//size:down/Incorrecto, la frase fue dicha por el escritor y empresario Dale Carnagie (1888-1955). Uno de sus libros más famoso es (Cómo ganar amigos e influír en las personas)." , "Dante"));
        }

        dialogTexts.Add(new DialogData("After this, you'll send me to the SecondScene!", "Dante"));
        dialogTexts.Add(new DialogData("Where you'll have to create a VERY simple mini game and make me react to it.", "Dante"));

        DialogManager.Show(dialogTexts);
    }
}