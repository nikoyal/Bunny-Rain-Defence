using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		showBannerAd();

	}

	private void showBannerAd()
	{
		string adID = "ca-app-pub-4076551740851810/4176317920";

		//***For Testing in the Device***
		//AdRequest request = new AdRequest.Builder()
			//.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
			//.AddTestDevice("1E84E34350774F47")  // My test device.
			//.Build();

		//***For Production When Submit App***
		AdRequest request = new AdRequest.Builder().Build();

		BannerView bannerAd = new BannerView(adID, AdSize.SmartBanner, AdPosition.Bottom);
		bannerAd.LoadAd(request);
	}

	// Update is called once per frame
	void Update () {

	}
}