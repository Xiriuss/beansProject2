using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class FishingMain : MonoBehaviour
{
    //INITIALISING VARIABLES
    public bool haveFish = true;
    public int aquariumCount = 0;
    public int reelTime = 0;
    //public string fishType = null;
    public float fishCollection = 0;
    public bool gameFinished = false;
    public bool fishQuotaMet = false;
    public FishType fishType;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("You caught a " + fishType.fish[Random.Range(0, 4)] + "!");
        Debug.Log("GAME START!");
        Debug.Log("With your crew to your left and right, you all ready your fishing rods before the fierce, crashing waves, prepared to cast. You pray to the gods for a bountiful day.");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            LineCast();
            CheckFishQuota();
        }
    }

    public void LineCast()
    {
        Debug.Log("You cast your line...");
        GetFish();
        aquariumCount++;
        Debug.Log("You now have " + aquariumCount + " fish in your bucket.");
    }

    public void GetFish()
    {
        int randomGetFish = Random.Range(0, fishType.fish.Length);
        if (fishType.fish != null && fishType.fish.Length >= 0)
        {
            Debug.Log("You caught a " + fishType.fish[randomGetFish] + "!");
        }
        else
        {
            Debug.Log("Error");
        }
    }

    public void CheckFishQuota()
    {
        if (aquariumCount >= 10)
        {
            Debug.Log("You've reached your quota for today.");
            gameFinished = true;
        }
    }
}
