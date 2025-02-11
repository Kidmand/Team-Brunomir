using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class SeventhSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        //Continuación de los diálogos entre los personajes Dafne y Dante en el Bosque.  
        dialogTexts.Add(new DialogData("/emote:Normal/Si, a mi realmente me parece impresionante esto lo de las huellas. Es lo que más me inquieta de toda la historia.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Después de lo sucedido, los días pasaban pero todo el mundo estaba pendiente que ocurrieran más cosas, por alguna extraña razon, se sentía en el ambiente.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Qué se sentía en el ambiente?." , "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/No sé, era como si se supiera que iban a pasar más cosas. Y de hecho, ocurrieron.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Mientras los días pasaban del primer suceso ocurrido, a la mujer se la veía cada vez más demacrada y desañilada, como si estuviera enferma. Hasta tal punto de parecer cadavérica.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Y que pasó con los niños?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Después de lo ocurrido, nadie volvió a ver a los niños hasta el segundo suceso.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/¿Qué ocurrió?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Ese día hacía un atardecer hermoso, razón por la cual muchos residentes salieron a pasear al bosque. Fueron muchos lo que escucharon los gritos desgarradores de un niño.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Ayy nooooo!, /wait:0.1//emote:Sad/¿No me digas que fue el niño de esa familia?", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Sad/Si, uno de los residentes que estaba paseando por el bosque escuchó los gritos y se acercó de inmediato al lugar. Algo que jura haberse arrepentido tras haber visto aquella escena tan horrosa.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sad/¡Probre niño!.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Ese hombre encontró al niño en las mismas condiciones que aquel ciervo, además el hombre mencionó que vió algo con forma humanoide retirarse de la escena a toda prisa.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Según palabras del hombre que presenció la escena, aquella cosa con aspecto humanoide, llevaba ropa femenina en muy malas condiciones.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¿Pe... pero qué era aquello que vió el hombre?.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Sad/Nadie lo sabe. /wait:0.1//emote:Normal/A medida que pasaba el tiempo, la escena del crimen se iba llenando de gente. Algunos residentes fueron hacia la casa de la esposa para avisarle lo que había ocurrido.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Cuando la mujer se enteró, corrió despavorida hacia la escena presenciando a su hijo destrozado.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡Dios mío!, /wait:0.1//emote:Sad/quiero llorar.", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Si, se que es fuerte la historia. /wait:0.1//emote:Sad/Lo siento si te hice sentir mal.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Pensativa/No te preocupes, soy sensible para estas cosas pero estoy bien. ¿Qué pasó después?. ", "Dafne"));
        dialogTexts.Add(new DialogData("/emote:Normal/Se hizo una investigación muy profunda por toda la ciudad y sobre todo a la familia en cuestión.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/La mujer se volvió loca a los pocos días de la muerte de su hijo. Prácticamente no se despegaba de su otra hija, la niña.", "Dante"));
        dialogTexts.Add(new DialogData("/size:down//emote:Normal/Los días pasaron y no encontraban nada, excepto un artilugio que parecía ser una esfinge. Según arqueólogos, dijeron que la esfinge tenía aproximadamente 2000 años y que era procedente de Egipto.","Dante"));
        dialogTexts.Add(new DialogData("/emote:Sorpresa/¡QUEE, EL PADRE!, ¿Pe, pero cómo?. Si él estaba en Egipto.", "Dafne"));  
        dialogTexts.Add(new DialogData("/emote:Normal/Si, el padre se encontraba aún en Egipto cuando ocurrió. Por eso la policía lo descartó como sospechoso.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Pero muchos sospechan que él volvió mucho antes de que ocurriera el segundo suceso.", "Dante"));

        DialogManager.Show(dialogTexts);

        StartCoroutine(WaitAndChangeScene.WaitDialog(DialogManager, ChangeSceneScript));
    }
}