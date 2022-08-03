using System.IO;
using UnityEngine;

namespace Maze
{
    public class JSonData : ISaveData
    {

        string SavePath = Path.Combine(Application.dataPath, "JSONData.json");

        public void SaveData(PlayerData player)
        {
            string FileJSON = JsonUtility.ToJson(player);
            File.WriteAllText(SavePath, FileJSON);
        }
        public PlayerData Load()
        {
            PlayerData result = new PlayerData();
            if (!File.Exists(SavePath))
            {
                Debug.Log("FILE NOT EXIST");
                return result;
            }
            string json = File.ReadAllText(SavePath);
            result = JsonUtility.FromJson<PlayerData>(json);

            return result;
        }

        //public void SaveDataBaff(HealthData health)
        //{
        //    string FileJSON = JsonUtility.ToJson(health);
        //    File.WriteAllText(SavePath, FileJSON);
        //}

        //public HealthData LoadBaff()
        //{
        //    HealthData result = new HealthData();
        //    if (!File.Exists(SavePath))
        //    {
        //        Debug.Log("FILE NOT EXIST");
        //        return result;
        //    }

        //    string json = File.ReadAllText(SavePath);
        //    result = JsonUtility.FromJson<HealthData>(json);

        //    return result;
        //}
    }
}