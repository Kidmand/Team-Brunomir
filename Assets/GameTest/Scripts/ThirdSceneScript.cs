using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class ThirdSceneScript : MonoBehaviour
{
    public DialogManager DialogManager;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Here I will inform you of the results in the previous Scenes.", "Dafne"));

        dialogTexts.Add(new DialogData("You choose option A - B - C in the first scene.","Dante"));

        dialogTexts.Add(new DialogData("The outcome of the mini-game was 1 - 2 - 3.", "Dafne"));

        dialogTexts.Add(new DialogData("So the result is of the game is A - B - C + 1 - 2 - 3.", "Dante"));

        dialogTexts.Add(new DialogData("And that's basically it!", "Dafne"));

        dialogTexts.Add(new DialogData("I hope you had fun in this little test! ", "Dante"));

        dialogTexts.Add(new DialogData("I'm looking forward to see what you're capable of!", "Dafne"));

        DialogManager.Show(dialogTexts);
    }
}
