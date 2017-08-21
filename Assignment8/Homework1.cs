using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
	public Text DisplayText;
	public Button LowerButton;
	public Button HigherButton;
	public Button YouWin;
	public Button PlayAgain;
	public Button PlayNow;
	int middle;
	int left;
	int right;
	int guesscount;

	void Start () {
		left = 0;
		right = 1000000;
		guesscount = 0;
	}
	public void lower(){
		guesscount++;
		right = middle - 1;
		middle = (left + right) / 2;
		DisplayText.text = "Is it " + middle + "?" ;
		HigherButton.gameObject.SetActive(true);
		LowerButton.gameObject.SetActive(true);
		YouWin.gameObject.SetActive(true);
		PlayNow.gameObject.SetActive (false);
		PlayAgain.gameObject.SetActive(false);
	}
	public void higher (){
		guesscount++;
		right = middle - 1;
		middle = (left + right) / 2;
		DisplayText.text = "Is it " + middle + "?";
		HigherButton.gameObject.SetActive(true);
		LowerButton.gameObject.SetActive(true);
		YouWin.gameObject.SetActive(true);
		PlayNow.gameObject.SetActive (false);
		PlayAgain.gameObject.SetActive(false);
	}
	public void Win (){
		guesscount++;
		DisplayText.text = "OMG after " + guesscount + " times fooling myself. I DID IT AT LAST!";
		HigherButton.gameObject.SetActive(false);
		LowerButton.gameObject.SetActive(false);
		YouWin.gameObject.SetActive(false);
		PlayNow.gameObject.SetActive (false);
		PlayAgain.gameObject.SetActive(true);
	}
	public void playAgain(){
		DisplayText.text = "Pick a number from 0 to 1000000, I'm gonna read your mind and tell you what your number is...";
		HigherButton.gameObject.SetActive(false);
		LowerButton.gameObject.SetActive(false);
		YouWin.gameObject.SetActive(false);

		PlayAgain.gameObject.SetActive(false);
		PlayNow.gameObject.SetActive (true);
	}

	void Update () {
		
	}
}
