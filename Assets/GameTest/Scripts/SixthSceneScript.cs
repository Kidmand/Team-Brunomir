using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class SixthSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        //Continuación de los diálogos entre los personajes Dafne y Dante en el Bosque.  
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/Resulta que el hombre debía irse con urgencia a un lugar de Egipto a buscar un artilugio. Esto se sabe porque un residente de la ciudad lo esuchó mientras hablaba con uno de sus amigos o socios trajeados.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/También se sabe que el esposo le pidió al otro hombre que fuere lo que fuere no dejara a sus hijos desprotegidos.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Hay algo raro en esto, por qué solo los niños? ¿Qué hay de la esposa?." , "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/De hecho, eso mismo se preguntaba el residente que escuchó la conversación.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Hay muchas supersticiones al respecto de eso. Muchos dicen que el hombre trataba de cuidar a los niños de la mujer.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿No se sabe que artilugio buscaba el esposo?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/No, pero luego me centro en eso. Por lo pronto te sigo narrando la historia.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Está bien, /wait:0.1//emote:Pensativa/muy interesante hasta ahora.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Luego que el esposo se haya ido a Egipto, las cosas parecían normales. Hasta que un día, un residente escuchó de madrugada que alguien gritaba en el bosque, se trataba de un grito fememino.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/El hombre no se atrevió a ver que era lo que sucedía, según sus palabras, el grito era aterrador...", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Fue al bar que estaba cerca de su casa y les contó lo que había escuchado. De inmediato todos los hombres partieron hacia el bosque armados de antorchas, palos, cuchillos y escopetas.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Cuando llegaron al lugar en dónde se pretendía que había ocurrido el grito, se encontró un ciervo destrozado entero.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Los hombres quedaron horrorizados al ver la escena frente a sus ojos.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Ayy, que horror!.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/También encontraron un reloj de mujer. Los hombres llamaron a la policía y comenzó una investigación.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿De quién era el reloj?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Hasta la fecha no se ha encontrado el dueño, pero todos sabemos en esta ciudad que ese reloj pertenecía a la esposa.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Pero la policía no pudo determinar de quién era el reloj?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Por supuesto que entrevistaron a cada mujer y hombre residente de la ciudad cercana al bosque. Obvio que también se entrevistó a la esposa, negó que el reloj fuera suyo...", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Y dónde estaba ella cuando ocurrieron los sucesos?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Según se sabe, ella estaba durmiendo durante los sucesos. También se sabe que ella presentó coartada afirmando que el guardia de la casa nunca la vió salir.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/Pero el guardia trabajaba para ellos, podría haber mentido.", "Dafne"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/Si, pero la policía aceptó su testimonio. En el lugar no se encontraron huellas ni ninguna otra pista que indicara que un ser humano estuviera en la escena, lo único que se encontró fueron huellas de animales.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Todas las huellas fueron identificadas según la especie de animal, excepto una.","Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡En serio!, ¿Qué era lo raro en la huella?", "Dafne"));  
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/Los guardabosques dijeron que esa huella no se parecía a nada que hubieran visto, que se trataba de algún animal aún no descubierto o que las huellas fueron alteradas con la clara idea de borrar pistas.", "Dante")); 
        dialogTexts.Add(new DialogData("/emote:Pensativa/Eso suena aún más terrorífico.", "Dafne"));     

        DialogManager.Show(dialogTexts);

        StartCoroutine(SceneChanger.WaitAndChangeScene(DialogManager, ChangeSceneScript));
    }
}