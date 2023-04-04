using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    private string dataDirPath = "";
    private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName){
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }
    public GameData Load(){

        string fulPath = Path.Combine(dataDirPath,dataFileName);
        GameData loadedData = null;
        if(File.Exists(fulPath)){

            try{
                string dataToLoad = "";
                using(FileStream stream = new FileStream(fulPath,FileMode.Open)){
                    
                    using(StreamReader reader = new StreamReader(stream)){

                        dataToLoad = reader.ReadToEnd();
                    }
                }
                loadedData = JsonUtility.FromJson<GameData>(dataToLoad);
            }
            catch(Exception e){

                Debug.LogError("Error occured when loaded data from file");
            }
        }
        return loadedData;

    }
    public void Save(GameData data){

        string fulPath = Path.Combine(dataDirPath,dataFileName);
        try{
            Directory.CreateDirectory(Path.GetDirectoryName(fulPath));

            string dataToStore = JsonUtility.ToJson(data,true);

            using(FileStream stream = new FileStream(fulPath, FileMode.Create)){
                using(StreamWriter writer = new StreamWriter(stream)){

                    writer.Write(dataToStore);
                }
            }
            
        }
        catch(Exception e){
            Debug.LogError("Error occured when save to datapath");
        }
    }
}
