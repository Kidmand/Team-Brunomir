using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class FifthSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        // Diálogos de los personajes Dafne y Dante en el Bosque.  
        dialogTexts.Add(new DialogData("/emote:Normal/Por cierto, ¿De dónde eres?.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/No soy de por aquí, de hecho hace poco que vine a la ciudad por lo que no conozco mucho. Además, me gusta explorar nuevos lugares y principalmente quería venir a este bosque.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Happy/Bueno, hice bien en traerte entonces." , "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sonrojada/Si, gracias por invitarme.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/La historia que te voy a contar es algo real que sucedió en una casa que se encuentra en este bosque. Algo que hasta la fecha nadie sabe bien que pasó. ", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Ohh, eso hace que se me erice la piel! /emote:Pensativa/¿Qué fue lo que sucedió?.", "Dafne"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/Todo pasó una noche de invierno hace aproximadamente 10 años atrás. En la casa vivía una familia pudiente de mucho dinero, no se relacionaban mucho con la gente de por aquí.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/En general, las personas los tenían como una familia extraña. Si bien eran amables las veces que hablaban con alguien de la ciudad, todas las personas que hablaron con ellos solían sentirse extrañamente en alerta.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Como si algo les advirtiera de algún peligro, quizá el propio instinto de supervivencia.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down//emote:Pensativa/Eso que mencionas es algo que siempre me dió miedo. Porque es cierto que hay personas que aunque uno no sepa porqué, pero el cuerpo nos avisa de que hay algo mal con ellos.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Si, estoy totalmente de acuerdo contigo.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/La familia a pesar de lo que la gente decía, eran muy amables y no causaban problema alguno. Es más, en general trataban de ayudar, pero con el tiempo la familia cada vez se volvía más alejada de todos.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Los niños cada vez que salían de la casa prácticamente tenían un andar muy rápido.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Cuántos niños eran?.", "Dafne"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/Eran dos, una niña y un niño. Él tenía 13 años y ella 12 años, siempre salían juntos. Luego estaba la esposa, que era una mujer muy hermosa y el hombre, que claramente tenía aspecto de hombre de negocios. Él tenía 47 y su mujer 44.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Y de qué trabajaban ellos?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Nadie nunca lo supo en realidad, muchas de las personas de por aquí veían al hombre hablar con otros hombres trajeados. Claramente hombres de la alta sociedad.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/De la mujer aún es más misterioso, ya que nadie en general tenía la más mínima idea de lo que hacía la mujer. Se la veía mucho menos que el hombre y por lo general las veces que se la veía eran por las noches.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/Todo esto que me cuentas luce tan extraño.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Si, lo es y aún se pone más extraño.", "Dante"));

        DialogManager.Show(dialogTexts);

        StartCoroutine(WaitAndChangeScene.WaitDialog(DialogManager, ChangeSceneScript));

    }
}
