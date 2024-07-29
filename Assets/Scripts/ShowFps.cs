using System;
using UnityEngine;

[ExecuteInEditMode]
[Serializable]
public class ShowFps : MonoBehaviour
{

	private float updateInterval;

	private double lastInterval;

	private int frames;

	public ShowFps()
	{
		this.updateInterval = 1f;
	}

	public void Start()
	{
		this.lastInterval = (double)Time.realtimeSinceStartup;
		this.frames = 0;
	}

	public void OnDisable()
	{
		
	}

	public void Update()
	{
		this.frames++;
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if ((double)realtimeSinceStartup > this.lastInterval + (double)this.updateInterval)
		{
			/*if (!this.gui)
			{
				this.gui = new GameObject("FPS Display", new Type[]
				{
					typeof(GUIText)
				})
				{
					hideFlags = HideFlags.HideAndDontSave,
					transform = 
					{
						position = new Vector3((float)0, (float)0, (float)0)
					}
				}.GetComponent<GUIText>();
				this.gui.pixelOffset = new Vector2((float)5, (float)55);
			}
			float a = (float)((double)this.frames / ((double)realtimeSinceStartup - this.lastInterval));
			float num = 1000f / Mathf.Max(a, 1E-05f);
			this.gui.text = num.ToString("f1") + "ms " + a.ToString("f2") + "FPS";
			this.frames = 0;
			this.lastInterval = (double)realtimeSinceStartup;*/
		}
	}

	public void Main()
	{
	}
}
