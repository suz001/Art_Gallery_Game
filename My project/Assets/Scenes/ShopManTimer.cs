using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class ShopManTimer : MonoBehaviour
{
    public NPCdialog npcD;
    public GameObject businessMan;
    private bool attractorMode, isRunning;
     
    private void Start(){
        attractorMode = true;
        isRunning = false;
    }

    private void OnEnable(){

        //TimeMan.OnMinuteChanged+= TimeCheck;
        TimeMan.OnHourChanged+= TimeCheck;
    }
    private void OnDisable(){
        //TimeMan.OnMinuteChanged -= TimeCheck;
        TimeMan.OnHourChanged-= TimeCheck;
    }
    private void TimeCheck(){
        if(attractorMode && !isRunning) StartCoroutine( Cycle() );
    }
    private IEnumerator Cycle(){

        isRunning = true;
        businessMan.SetActive(true);
        yield return new WaitForSeconds(5);
        businessMan.SetActive(false);
        isRunning=false;
    }
}
//private float lastSpawnTime = 0;
 
// If you want spawning to happen 'exactly' after 30s, set lastSpawnTime to Time.time in Start()
// If you want want the first spawn to happen 'instantly', set lastSpawnTime to minus spawnTimeInterval in Start()
 /*
void Update(){
    if(Time.time - lastSpawnTime > spawnTimeInterval){
        lastSpawnTime = Time.time;
        GameObject newInfected = Instantiate(infectedPrefab, spawnLocation.position, Quaternion.identity);
    }
}
if((Time.time - lastCompletedCycleTime) >= interval){
    // Here: insert above code example to turn on/off player objects
    lastCompletedCycleTime = Time.time;
}*/
