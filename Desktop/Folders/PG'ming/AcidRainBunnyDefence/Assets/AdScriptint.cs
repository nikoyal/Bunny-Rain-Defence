using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdScriptint : MonoBehaviour
{

	bool hasShownAdOneTime;

	// Use this for initialization
	void Start()
	{
		//Request Ad
		RequestInterstitialAds();
	}

	void Update()
	{
		if (Stats.gamesplayed == 5)
		{
			if (!hasShownAdOneTime)
			{
				hasShownAdOneTime = true;
				Invoke("showInterstitialAd", 3.0f);
			}
			Stats.gamesplayed = 0;
		}
	}

	public void showInterstitialAd()
	{
		//Show Ad
		if (interstitial.IsLoaded())
		{
			interstitial.Show();

			//Stop Sound
			//

			Debug.Log("SHOW AD XXX");
		}

	}

	InterstitialAd interstitial;
	private void RequestInterstitialAds()
	{
		string adID = "ca-app-pub-4076551740851810/5141915231";

		#if UNITY_ANDROID
		string adUnitId = adID;
		#elif UNITY_IOS
		string adUnitId = adID;
		#else
		string adUnitId = adID;
		#endif

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);

		//***Test***
		//AdRequest request = new AdRequest.Builder()
		//.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
		//.AddTestDevice("1E84E34350774F47")  // My test device.
		//.Build();

		//***Production***
		AdRequest request = new AdRequest.Builder().Build();

		//Register Ad Close Event
		interstitial.OnAdClosed += Interstitial_OnAdClosed;

		// Load the interstitial with the request.
		interstitial.LoadAd(request);

		Debug.Log("AD LOADED XXX");

		}

		//Ad Close Event
		private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
		{
		//Resume Play Sound

		}
		}