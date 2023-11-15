using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<string, Item> items;
    private Stack<Item> historyStack;

    public Inventory()
    {
        items = new Dictionary<string, Item>();
        historyStack = new Stack<Item>();

    }

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
    public void HandleCollision(Item item)
    {
        Add(item);
    }

    public void Use(string itemName, Pokemon targetPokemon)
    {
        if (items.ContainsKey(itemName))
        {
            Item item = items[itemName];
            //item.SetTarget(targetPokemon);
            item.Execute();
            historyStack.Push(item);
        }
    }
}
