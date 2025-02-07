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
        
        // Diálogos entre los personajes y uso de emociones y reacciones en los sprites.
        dialogTexts.Add(new DialogData("/emote:Happy/¡Hola, /size:init/mi nombre es Dante!.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Happy/Hola Dante, yo soy Kidmand. ¡Encantado de conocerte!", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Happy/ El placer es mío.", "Dante"));
        dialogTexts.Add(new DialogData("Hay algo de lo que quiero hablarte Kidmand, quizá te resulte anormal pero considero que es muy importante saberlo.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Oh, por supuesto Dante!/wait:0.1//emote:Happy/ Estoy curioso de saber de que se trata, dime. ", "Kidmand"));
        dialogTexts.Add(new DialogData("¿Tú consideras que el desarrollo personal es algo importante en nuestras vidas?.", "Dante"));
        dialogTexts.Add(new DialogData("Siendo sincero, si considero que sea una parte fundamental en nuestras vidas.", "Kidmand"));
        dialogTexts.Add(new DialogData("De hecho es tan importante que creo que en las universidades debería darse un curso al respecto.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Vaya! /wait:0.1//emote:Normal/Sabes que justo eso es algo que también creo yo.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Happy/Bueno, ya tenemos algo en común.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Happy/¡Definitivamente! /wait:0.1//emote:Normal/Y ya que preguntas sobre eso Dante, te tengo un pequeño juego. ¿Te animas a completarlo?.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Oh, un juego!... /wait:0.1//emote:Normal/¿De qué se trata?.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down/Te haré una pregunta sobre una frase referida al desarrollo personal y te daré tres opciones para elegir la correcta, ¿De Acuerdo?.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Happy/Si, me encanta. Adelante, estoy listo.", "Dante"));


        // Añadir opciones de selección. 
        var selectionText = new DialogData("/size:down/Bueno, veamos si conoces a un famoso líder de desarrollo personal llamado Brian Tracy. En unos de sus maravillosos cursos (El seminario Fénix) dice una frase, ¿La cúal sería?:", "Kidmand");
        selectionText.SelectList.Add("Correct","Jamás, jamás, jamás se den por vencidos.");
        selectionText.SelectList.Add("Incorrect1","Lo que la mente del hombre puede concebir y creer, puede lograrse.");
        selectionText.SelectList.Add("Incorrect2","El éxito es una cuestión de motivación, creencias y acostumbrarse a la acción.");
        selectionText.Callback = () => HandleSelection();
        dialogTexts.Add(selectionText);

        DialogManager.Show(dialogTexts);
    }


        // Manejar la selección del jugador, y seguir pequeños diálogos entre los personajes. 
    private void HandleSelection()
    {
        var dialogTexts = new List<DialogData>();

        if (DialogManager.Result == "Correct")
        {
            dialogTexts.Add(new DialogData("/emote:Sorpresa/ ¡Oh, felicitaciones!/wait:0.1//emote:Happy/ Tienes una excelente memoria al recordar la frase correctamente o tiene suerte por haber adivinado ;).", "Kidmand"));
            dialogTexts.Add(new DialogData("/emote:Happy/ ¡Muchas Gracias! /wait:0.1//emote:Normal/Sí, vi el seminario fénix, me pareció extraodinario.", "Dante"));
        }
        else if (DialogManager.Result == "Incorrect1")
        {
            dialogTexts.Add(new DialogData("/size:down/Incorrecto, la frase fue dicha por el escritor Napoleón Hill (1883-1970). Uno de los autores de autoayuda y superación más prestigioso del mundo. ", "Kidmand"));
            dialogTexts.Add(new DialogData("/emote:Sad/Supongo que tendré que seguir aprendiendo más.", "Dante"));
        }
        else if (DialogManager.Result == "Incorrect2")
        {
            dialogTexts.Add(new DialogData("/size:down/Incorrecto, la frase fue dicha por el escritor y empresario Dale Carnagie (1888-1955). Uno de sus libros más famoso es (Cómo ganar amigos e influír en las personas)." , "Kidmand"));
            dialogTexts.Add(new DialogData("/emote:Sad/Supongo que tendré que seguir aprendiendo más.", "Dante"));
        }


        // En caso de que la respuesta sea incorrecta.    
        if (DialogManager.Result != "Correct")
        { 
            dialogTexts.Add(new DialogData("Vamos, no te desanimes. Tampoco se pueden saber todas las frases del mundo.", "Kidmand"));
            dialogTexts.Add(new DialogData("/emote:Happy/Tienes razon, de igual manera gracias por el juego. Me dieron más ganas de aprender y mejorar.", "Dante"));
        }

        dialogTexts.Add(new DialogData("/emote:Happy/Me alegra que hayas dicho eso.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Happy/Bien, me alegra haberte conocido Kidmand. /wait:0.1//emote:Normal/Si me permites me iré a mi cuarto.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Happy/¡Claro Dante! /wait:0.1//emote:Normal/Espero verte pronto.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Happy/¡Hasta luego!", "Dante"));
        dialogTexts.Add(new DialogData("Presiona escape para ir al cuarto de Dante"));

        DialogManager.Show(dialogTexts);
    }
}