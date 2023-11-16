using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;
using JetBrains.Annotations;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, Item> items = new Dictionary<string, Item>();
    private Stack<Item> historyStack = new Stack<Item>();

    public void Add(Item newItem)
    {
        if (items.ContainsKey(newItem.Name))
        {
            items[newItem.Name].Quantiny += newItem.Quantiny;
        }
        else
        {
            items[newItem.Name] = newItem;
        }
    }

    public void Use(string itemName, Pokemon targetPokemon)
    {
        if (items.ContainsKey(itemName))
        {
            Item item = items[itemName].Clone() as Item;
            item.SetTarget(targetPokemon);
            item.Execute();
            historyStack.Push(item);

            item.Quantiny--;
            if (item.Quantiny <= 0)
            {
                items.Remove(itemName);
            }
        }
        else
        {
            Debug.Log("Item notfound in inventory");
        }
       
    }
    public void Undo()
    {
        if(historyStack.Count > 0)
        {
            Item lastItem = historyStack.Pop();
            lastItem.Undo();
            Add(lastItem);
        }
    }
}
