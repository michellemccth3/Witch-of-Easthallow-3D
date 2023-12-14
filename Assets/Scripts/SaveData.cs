using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public Inventory inventory = new Inventory();

private void Update()
{
    if(Input.GetKeyDown(KeyCode.Tab))
    {
        SaveToJson();
    }
    if(Input.GetKeyDown(KeyCode.L))
    {
        LoadFromJson();
    }
}

    public void SaveToJson()
    {
        string inventoryData = JsonUtility.ToJson(inventory);
        string filePath = Application.persistentDataPath + "/InventoryData.json";
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, inventoryData);
        Debug.Log("Data Saved");
    }

    public void LoadFromJson()
    {
        string filePath = Application.persistentDataPath + "/InventoryData.json";
        string inventoryData = System.IO.File.ReadAllText(filePath);
        inventory = JsonUtility.FromJson<Inventory>(inventoryData);
        Debug.Log("Save Loaded");
    }
}

[System.Serializable]
public class Inventory
{
    public int level;
    public int coins;
    public bool isFull;
    public List<Items> items = new List<Items>();
}

[System.Serializable]
public class Items
{
    public string name;
    public string dec;
}
