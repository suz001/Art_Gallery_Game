using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

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
            /*Destroy(this.gameObject);
            return;*/
        }
        instance = this;
        //DontDestroyOnLoad(this.gameObject);
        


    }
    /*
    private void OnEnable(){

        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }
    private void OnDisable(){

        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        Debug.Log("loaded");
        this.DataPersistenceObject = FindAllDataPersistenceObjects();
        LoadGame();
        
    }
    public void OnSceneUnloaded(Scene scene){
        Debug.Log("unloaded");
        SaveGame();
    }
    */
    private void Start(){
        this.dataHandler = new FileDataHandler(Application.persistentDataPath,fileName);
        this.DataPersistenceObject = FindAllDataPersistenceObjects();
        LoadGame();
    }
    public void NewGame(){
        Debug.Log("new");
        this.gameData = new GameData();
    }
    public void LoadGame(){
        Debug.Log("LOADGAME");
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
        /*if(this.gameData == null){
            return;
        }*/
    
        foreach(IdDataPersistence dataPersistenceObj in DataPersistenceObject){
            dataPersistenceObj.SaveData(ref gameData);
            //Debug.Log("test");
        }
        
        dataHandler.Save(gameData);
    }
    private List<IdDataPersistence> FindAllDataPersistenceObjects(){
        IEnumerable<IdDataPersistence> DataPersistenceObject = FindObjectsOfType<MonoBehaviour>().OfType<IdDataPersistence>();
        
        return new List<IdDataPersistence>(DataPersistenceObject);
    }

    public bool HasGameData(){

        return gameData !=null;
    }

}
