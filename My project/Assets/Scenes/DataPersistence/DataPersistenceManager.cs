using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistenceManager : MonoBehaviour
{

    [Header("File Storage Config")]

    [SerializeField] private string fileName;
    private GameData gameData;

    private List<IdDataPersistence> DataPersistenceObject;

    private FileDataHandler dataHandler;
    public static DataPersistenceManager instance { get; private set;}
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("Found more than one Data persistence manager in the scene");

        }
        instance = this;

    }
    private void Start(){
        
        this.dataHandler = new FileDataHandler(Application.persistentDataPath,fileName);
        this.DataPersistenceObject = FindAllDataPersistenceObjects();
        //Debug.Log("Hit count: " + DataPersistenceObject.Count);
        LoadGame();
    }
    public void NewGame(){
        this.gameData = new GameData();
    }
    public void LoadGame(){

        this.gameData = dataHandler.Load();

        if(this.gameData==null){
            Debug.Log("no data was found. Initializing to defult");
            NewGame();
        }
        foreach(IdDataPersistence dataPersistenceObj in DataPersistenceObject){
            //Debug.Log("test");
            dataPersistenceObj.LoadData(gameData);

        }
        //Debug.Log("Loaded total time = " + gameData.PlayerPosition);
    }
    public void SaveGame(){
        foreach(IdDataPersistence dataPersistenceObj in DataPersistenceObject){
            dataPersistenceObj.SaveData(ref gameData);
            //Debug.Log("test");
        }
        
        //Debug.Log("Saved total time = "+ gameData.PlayerPosition);
        
        dataHandler.Save(gameData);
    }
    private List<IdDataPersistence> FindAllDataPersistenceObjects(){
        IEnumerable<IdDataPersistence> DataPersistenceObject = FindObjectsOfType<MonoBehaviour>().OfType<IdDataPersistence>();
        
        return new List<IdDataPersistence>(DataPersistenceObject);
    }
    private void OnApplicationQuit(){
        //foreach(IdDataPersistence dataPersistenceObj in DataPersistenceObject){
            
        //}
        //Debug.Log("Hit count: " + DataPersistenceObject.Count);
        SaveGame();
    }
}
