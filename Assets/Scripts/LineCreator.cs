using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.LowLevel;
using UnityEngine.UI;

public class LineCreator : MonoBehaviour
{
	private GameObject linePrefab;

	private Line activeLine;

	public GameObject normalPrefab;
	public GameObject boostedPrefab;
	public GameObject bouncyPrefab;

	public Button normalButton;
	public Button boostButton;
	public Button bouncyButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (linePrefab == null)
			return;

		if (Input.GetMouseButtonDown(0))
		{
			GameObject lineGO = Instantiate(linePrefab);
			activeLine = lineGO.GetComponent<Line>();
		}

		if (Input.GetMouseButtonUp(0))
		{
			activeLine = null;
		}

		if (activeLine)
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			activeLine.UpdateLine(mousePos);
		}
	}

	public void SetLinePrefab(string lineName)
	{
		switch (lineName)
		{
			case "normal":
				linePrefab = normalPrefab;
				normalButton.interactable = false;
				boostButton.interactable = true;
				bouncyButton.interactable = true;
				break;
			case "boosted":
				linePrefab = boostedPrefab;
				normalButton.interactable = true;
				boostButton.interactable = false;
				bouncyButton.interactable = true;
				break;
			case "bouncy":
				linePrefab = bouncyPrefab;
				normalButton.interactable = true;
				boostButton.interactable = true;
				bouncyButton.interactable = false;
				break;
		}
	}




}
