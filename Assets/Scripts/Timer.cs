﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A timer
/// </summary>
public class Timer : MonoBehaviour
{
	#region Fields
	float totalSeconds = 0;
	float elapsedSeconds = 0;
	bool running = false;
	bool started = false;
	#endregion
	
	#region Properties
	public float Duration
    {
		set
        {
			if (!running)
            {
				totalSeconds = value;
			}
		}
	}
	public bool Finished
    {
		get { return started && !running; } 
	}
	public bool Running
    {
		get { return running; }
	}
    #endregion

    #region Methods
    void Update()
    {	
		if (running)
        {
			elapsedSeconds += Time.deltaTime;
			if (elapsedSeconds >= totalSeconds)
            {
				running = false;
			}
		}
	}
	public void Run()
    {	
		if (totalSeconds > 0)
        {
			started = true;
			running = true;
            elapsedSeconds = 0;
		}
	}
	#endregion
}
