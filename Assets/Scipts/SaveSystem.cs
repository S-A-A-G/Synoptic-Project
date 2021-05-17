using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem 
{

    public static void SaveGame(CharacterCreator savedChar)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/character";

        FileStream stream = new FileStream(path, FileMode.Create);

        SavedCharacterData data = new SavedCharacterData(savedChar);

        formatter.Serialize(stream, data);
        stream.Close();
    }


    public static SavedCharacterData LoadCharacter()
    {
        string path = Application.persistentDataPath + "/character";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SavedCharacterData data = formatter.Deserialize(stream) as SavedCharacterData;
            stream.Close();

            return data;
        }
        else{
            return null;
        }
    }
}
