using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokeball : Item
{
    public override void Execute()
    {
        target.IsCaught = true;

    }
    public override void Undo()
    {
        target.IsCaught = false;
    }
    private void Awake()
    {
        name = "Pokeball";

    }

}
