using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class SceneController : MonoBehaviour
{
	public CarEngine carYellow;
	public CarEngine carGray;
	public CarEngine carGreen;
	public CarEngine carBlue;
	public CarEngine carRed;

	//public PlayableDirector timelineStart;
	//public PlayableDirector timelineCarStart;
	public List<PlayableDirector> playableDirectors;
	public List<TimelineAsset> timelineAssets;

	// Start is called before the first frame update
	void Start()
	{
		carYellow.carStop += CarYellowStop;
		carGray.carStop += CarGrayStop;
		carGreen.carStop += CarGreenStop;
		carBlue.carStop += CarBlueStop;
		carRed.carStop += CarRedStop;

		
	}

	void startCarSerial()
	{
		carYellow.isStop = false;
	}

	void CarYellowStop()
	{
		carGray.isStop = false;
	}

	void CarGrayStop()
	{
		carGreen.isStop = false;
	}

	void CarGreenStop()
	{
		carBlue.isStop = false;
	}

	void CarBlueStop()
	{
		carRed.isStop = false;
	}

	void CarRedStop()
	{
		Debug.Log("finish 5 car run");
	}
}
