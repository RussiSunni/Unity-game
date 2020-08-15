using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public string playerName;
    public static bool animal001known,
                        animal002known,
                        animal003known,
                        animal004known,
                        animal005known,
                        animal006known,
                        animal007known,
                        animal008known,
                        animal009known,
                        animal010known,
                        animal011known,
                        animal012known,
                        animal013known,
                        animal014known,
                        animal015known,
                        animal016known,
                        animal017known,
                        animal018known,
                        animal019known,
                        animal020known,
                        animal021known,
                        animal022known,
                        animal023known;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        Debug.Log("saving");

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.playerName = playerName;
        data.animal001known = animal001known;
        data.animal002known = animal002known;
        data.animal003known = animal003known;
        data.animal004known = animal004known;
        data.animal005known = animal005known;
        data.animal006known = animal006known;
        data.animal007known = animal007known;
        data.animal008known = animal008known;
        data.animal009known = animal009known;
        data.animal010known = animal010known;
        data.animal011known = animal011known;
        data.animal012known = animal012known;
        data.animal013known = animal013known;
        data.animal014known = animal014known;
        data.animal015known = animal015known;
        data.animal016known = animal016known;
        data.animal017known = animal017known;
        data.animal018known = animal018known;
        data.animal019known = animal019known;
        data.animal020known = animal020known;
        data.animal021known = animal021known;
        data.animal022known = animal022known;
        data.animal023known = animal023known;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            playerName = data.playerName;

            animal001known = data.animal001known;
            animal002known = data.animal002known;
            animal003known = data.animal003known;
            animal004known = data.animal004known;
            animal005known = data.animal005known;
            animal006known = data.animal006known;
            animal007known = data.animal007known;
            animal008known = data.animal008known;
            animal009known = data.animal009known;
            animal010known = data.animal010known;
            animal011known = data.animal011known;
            animal012known = data.animal012known;
            animal013known = data.animal013known;
            animal014known = data.animal014known;
            animal015known = data.animal015known;
            animal016known = data.animal016known;
            animal017known = data.animal017known;
            animal018known = data.animal018known;
            animal019known = data.animal019known;
            animal020known = data.animal020known;
            animal021known = data.animal021known;
            animal022known = data.animal022known;
            animal023known = data.animal023known;
        }
    }
}

[Serializable]
class PlayerData
{
    public string playerName;
    public bool animal001known;
    public bool animal002known;
    public bool animal003known;
    public bool animal004known;
    public bool animal005known;
    public bool animal006known;
    public bool animal007known;
    public bool animal008known;
    public bool animal009known;
    public bool animal010known;
    public bool animal011known;
    public bool animal012known;
    public bool animal013known;
    public bool animal014known;
    public bool animal015known;
    public bool animal016known;
    public bool animal017known;
    public bool animal018known;
    public bool animal019known;
    public bool animal020known;
    public bool animal021known;
    public bool animal022known;
    public bool animal023known;
}

