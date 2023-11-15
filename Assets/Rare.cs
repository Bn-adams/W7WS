using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rare : Item
{
    public override void Execute()
    {
        target.Level++;

    }
    public override void Undo()
    {
        target.Level--;
    }
    private void Awake()
    {
        name = "Rare Candy";
        
    }

  
}
