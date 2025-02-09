using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class EighthSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;

    public ChangeScene ChangeSceneScript;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        //Continuación de los diálogos entre los personajes Dafne y Dante en la casa de la familia.  
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Por qué sospechan eso?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Muchos creen haberlo visto poco tiempo después de haber viajado a Egipto.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Luego de lo sucedido, y que el esposo supuestamente habría llegado después de la muerte de su hijo, la familia desapareció sin dejar el más mínimo rastro." , "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Los sucesos cesaron y no volvió a ocurrir más nada desde entonces dejando este caso como el más siniestro y horroso asesinato que ha vivido esta ciudad.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Ohh Dante! Esa historia es terrorífica, además nunca se supo lo que pasó lo que hace que la historia sea aún más terrorífica.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Lo sé Dafne. Esta casa que estamos viendo ahora perteneció a aquella familia. Como vez, hace 10 años fue clausurada y desde entonces nadie ha entrado en ella.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Dios mío!. /wait:0.1/Esta casa es tan grande y luce tan espeluznante.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Si, lo es. Siempre he querido entrar en ella y descubrir que fue lo que pasó. Estoy seguro que esa casa debe tener un cuarto secreto en donde existe un pazadizo hacia algún lugar en el bosque.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¿Por qué dices eso?", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Estoy muy seguro que aquella familia tuvo mucho que ver con la muerte de su hijo.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/Si, sabes que yo pienso lo mismo que tu. ¿Te animarías a entrar conmigo?", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¿Pero qué estás diciendo, estás loca?.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Piénsalo, ¿Qué podría pasar?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Mmmmmmm, /wait:0.1//emote:Happy/Está bien, entremos.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal//speed:down/Esta historia continurá.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Muchas gracias al equipo de TeamBrunomir por darme esta oportunidad. Les mando un enorme saludo.", "Dante"));

        DialogManager.Show(dialogTexts);

        StartCoroutine(SceneChanger.WaitAndChangeScene(DialogManager, ChangeSceneScript));
    }
}

/*
Se que para la escena 8 no uso el cambio de esena automático, pero le dejo el código por si el día de mañana sigo la implementación.
De igual manera está descativado directamente desde Unity, así que esta sería la última escena.
*/