using System.IO;
using System;
using System.Xml;
using UnityEngine;


namespace Maze
{


    public class XMLData : ISaveData
    {
        string SavePath = Path.Combine(Application.dataPath, "XMLData.xml");

        public void SaveData(PlayerData player)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Player");
            xmlDoc.AppendChild(rootNode);

            XmlElement element = xmlDoc.CreateElement("PlayerName");
            element.SetAttribute("value", player.Name);
            rootNode.AppendChild(element);

            element = xmlDoc.CreateElement("PlayerHealth");
            element.SetAttribute("value", player.Health.ToString());
            rootNode.AppendChild(element);

            element = xmlDoc.CreateElement("isDead");
            element.SetAttribute("value", player.PlayerDead.ToString());
            rootNode.AppendChild(element);

            xmlDoc.Save(SavePath);
            
        }

        public PlayerData Load()
        {
            PlayerData result = new PlayerData();

            if (!File.Exists(SavePath))
            {
                Debug.Log("FILE NOT EXIST");
                return result;
            }

            using (XmlTextReader reader = new XmlTextReader(SavePath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement("PlayerName"))
                    {
                        result.Name = reader.GetAttribute("value");
                    }
                    if (reader.IsStartElement("PlayerHealth"))
                    {
                        result.Health = Convert.ToInt32(reader.GetAttribute("value"));
                    }
                    if (reader.IsStartElement("isDead"))
                    {
                        result.PlayerDead = Convert.ToBoolean(reader.GetAttribute("value"));
                    }
                }
            }

                return result;
        }
    }
}