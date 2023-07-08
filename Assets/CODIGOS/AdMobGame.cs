using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobGame : MonoBehaviour
{
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    public void Start()
    {
        RequestInterstitial();
    }


    private void RequestInterstitial(){
#if UNITY_ANDROID
        string adUnitId = "code here...";

#else
        string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
    public void GameOver(){
        if (LogicaPersonaje.perdiste >= 10){
           
        if (this.interstitial.IsLoaded()){
            this.interstitial.Show();
        }
            LogicaPersonaje.perdiste = 0;
        }
    }


}
