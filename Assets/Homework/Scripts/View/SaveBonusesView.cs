using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;


#if UNITY_EDITOR
public class SaveBonusesView : MonoBehaviour
{
    public List<Transform> bonuses = new List<Transform>();

    //SavingPath
    private string savePath;
    public string directoryName;
    public string SceneName;
    
    public string SavingPath { get => savePath; set => savePath = value; }

    private void OnDrawGizmos()
    {
        SceneName = EditorSceneManager.GetActiveScene().name;
        directoryName = "Bonuses Data";
        SavingPath = Path.Combine(Application.dataPath + "/" + directoryName, "BonusesData_" + SceneName + ".xml");

    }

}
#endif