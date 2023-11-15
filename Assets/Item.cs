using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public interface ICommand
{
    void Execute();

    void Undo();
}
public abstract class Item : MonoBehaviour, ICommand
{
    

    [SerializeField]
    protected string name;
    [SerializeField] 
    protected int quantity = 1;

    protected Pokemon target = null;

    public string Name { get => name; }
    public int Quantiny { get => quantity; set => quantity = value; }
    public Pokemon Target { get => target; set => target = value; }

    public static Item operator ++(Item item)
    {
        item.quantity++;
        return item;
    }

    public static Item operator --(Item item)
    {
        item.quantity--;
        return item;


    }
    public static Item operator +(Item item1, Item item2)
    {
        item1.quantity += item2.quantity;
        return item1;

    }

    public abstract void Execute();
    public abstract void Undo();


}





    /*
    private string name;
    private string description;
    private string category;
    private int amount;

    public string Name { get => name; }
    public string Description { get => description; }
    public string Category { get => category; }
    public int Amount { get => amount; set => amount = value; }

    public Item(string name, string description, string category)
    {
        this.name = name;
        this.description = description;
        this.category = category;
        amount = 0;
    }


    public static Item operator ++(Item item)
    {
        item.amount++;
        return item;
    }

    */

