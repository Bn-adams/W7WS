using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    private bool IsCaught { get; set; }
    private int Level { get; set; }

  

   public void IncreasedLevel()
    {
        Level++;
    }
    public void SetCaught(bool status)
    {
        IsCaught = status;
    }
}
