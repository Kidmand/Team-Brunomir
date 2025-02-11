using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class ThirdSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        // Diálogos de los personajes Dafne y Dante en el parque.  
        dialogTexts.Add(new DialogData("/size:down//emote:Happy/¡Que hermosa la vista! /wait:0.1//emote:Normal/Al final fue bueno venir a despejarme al parque. Ahora que lo pienso, podría haber invitado a kidmand, me cayó de maravilla.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/En fin, voy a sentarme y disfurtar del clima y la vista.", "Kidmand"));
        dialogTexts.Add(new DialogData("/emote:Normal/!Uyy, pero que tiempo tan hermoso hace hoy! /wait:0.1//emote:Pensativa/Mmmmmm, ¿Quién será aquel chico recostado sobre el banco?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Tengo mucha curiosidad de saber que hace ahí, además luce amigable, voy a acercarme y presentarme.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/¡Holis, soy Dafne!/wait:0.1//emote:Sonrojada/ Mucho gusto en conocerte. ", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Ohh, que carajos!.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/Lo siento mucho por haberte asustado, /wait:0.1//emote:Normal/fue muy indescente presentarme de esa manera.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Happy/No te preocupes, /wait:0.1//emote:Normal/¿Cómo dijiste que te llamabas?, yo soy Dante.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Dafne, mucho gusto en conocerte Dante. Nuestros nombres se parecen bastante, que curioso.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Happy/El placer es mío Dafne. /wait:0.1//emote:Normal/Si, definitivamente en eso tenés razon. Por cierto, ¿Lindo el paisaje no crees?.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sonrojada/¡Siiii! /wait:0.1//emote:Normal/De hecho eso pensaba antes de venir a hablarte.", "Dafne"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/ Bueno, lo cierto es que luego de descansar un rato aquí, mi idea era ir al bosque. Ya que te has presentado te pregunto /emote:Happy/¿Te gustaría acompañarme?.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down//emote:Sonrojada/ ¡Sii, me encantaría acompañarte! /wait:0.1//emote:Normal/Creo que será divertido, si bien el tiempo está hermoso, hace un poco de calor a pesar de que estemos en otoño, con lo cual estaría bien ir al bosque que siempre suele estar más frío.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Happy/Concuerdo con lo que dices. /wait:0.1//emote:Normal/En ese caso, vamos y mientras te cuento una historia de terror y nos vamos conociendo. ¿Te parece?.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Ohh, que miedo! /wait:0.1//emote:Normal/Me encantan las historias de terror, así que si, me parece perfecto.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Happy/¡Perfecto! /wait:0.1//emote:Normal/Entonces vamos a disfrutar de un buen día en el bosque.", "Dante"));

        DialogManager.Show(dialogTexts);

        StartCoroutine(WaitAndChangeScene.WaitDialog(DialogManager, ChangeSceneScript));
    }
}
