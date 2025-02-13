using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class FourthSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;
    public ChangeScene ChangeSceneScript;
    public MonsterScript MonsterScript; // Referencia al script del monstruo.
    public Animator KidAnimator; // Referencia al Animator del niño.

    private bool hasShownDeathDialog = false; // Para asegurarnos de que el diálogo de muerte se muestre solo una vez.

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        // Dante hablando sobre el minijuego en su PC.  
        dialogTexts.Add(new DialogData("/emote:Normal/¡Que extraño! Este juego se abrió por si solo, creí sinceramente que no andaba.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Recuerdo probarlo varias veces durante los años y nunca anduvo, también probé desintalarlo pero tampoco pude.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/El juego en sí vino con esta computadora. Ahora que lo recuerdo, la persona de la tienda que me la vendió me dijo que esta era una máquina muy extraña." , "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Nunca supe porqué dijo eso, pero no me ha generado ningún problema, excepto este videojuego.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Creo haberlo jugado algunas veces hace como 10 años, lo recuerdo porque en ese entonces me parecía muy sangriento. ", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/También porque, en aquel entonces el juego se cerró por si mismo y desde ahí nunca volvió a funcionar...", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Para jugar era la tecla (A y D) para moverse, tecla (W) para saltar y tecla (F) para matar si no mal recuerdo.", "Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/¿Parece haber una pelea entre el mago y el niño? ¿Y si los matamos?","Dante"));
        dialogTexts.Add(new DialogData("/emote:Normal/Algo que me sorprende de este juego es que siempre hay escena distintas, pareciera no tener niveles.","Dante"));

        DialogManager.Show(dialogTexts);

        StartCoroutine(WaitAndAllowMovement.WaitDialog(DialogManager, MonsterScript, true));
    }

    // Desactivar el movimiento del monstruo y mostrar el diálogo después de matar al niño.
    private void Update()
    {
        if (KidAnimator.GetBool("KidDead") && !hasShownDeathDialog)
        {
            StartCoroutine(WaitAndAllowMovement.WaitDialog(DialogManager, MonsterScript, false));
            ShowDeathDialog();
            hasShownDeathDialog = true;
        }
    }

    public void ShowDeathDialog()
    {
        var deathDialogTexts = new List<DialogData>();

        // Nuevos diálogos cuando matamos al niño.
        deathDialogTexts.Add(new DialogData("/emote:Sorpresa/¡Que manera más brutal de matar a ese niño! Justo esto era a lo que me refería con sangriento.", "Dante"));
        deathDialogTexts.Add(new DialogData("/emote:Normal/¡Genial! Y ahora dejó de andar. Pero que juego de porquería...", "Dante"));
        deathDialogTexts.Add(new DialogData("/size:down//emote:Normal/MMMMMMMMMM. /wait:01//emote:Sorpresa/Ahora que lo recuerdo, aquella vez que lo jugué había matado a un ciervo y a un niño. En fin, este juego siempre me va a parecer extraño.", "Dante"));
        deathDialogTexts.Add(new DialogData("/emote:Normal/Mejor tomo una siesta y descanso un rato, luego invitaré a Kidmand si quiere acompañarme al parque.", "Dante")); 

        DialogManager.Show(deathDialogTexts);

        StartCoroutine(WaitAndChangeScene.WaitDialog(DialogManager, ChangeSceneScript));
    }
}