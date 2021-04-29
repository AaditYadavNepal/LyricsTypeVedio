using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = {  "When", "the" ,"night", "has" ,"come",
"And"," the", "land" ,"is", "dark",
"And", "the", "moon", "is", "the", "only", "light", "we'll", "see",
"No", "I", "won't", "be" ,"afraid",
"Oh"," I", "won't" ,"be","afraid",
"Just", "as", "long", "as", "you", "stand","stand","by","me",
"So", "darling", "darling",
"Stand" ,"by" ,"me", "oh"," stand", "by","me",
"Oh" ,"stand","by", "me",
"Stand", "by", "me",
"If", "the", "sky", "that", "we", "look", "upon",
"Should" ,"tumble ","and", "fall",
"Or", "the", "mountain"," should" ,"crumble"," to", "the" ,"sea",
"I" ,"won't", "cry", "I" ,"won't"," cry",
"No", "I", "won't", "shed" ,"a" ,"tear",
"Just", "as", "long", "as", "you", "stand", "stand" ,"by"," me",
"And", "darling"," darling",
"Stand" ,"by", "me", "oh", "stand" ,"by", "me",
"Oh" ,"stand", "now", "stand", "by", "me",
"Stand", "by"," me",
"So","darling", "darling",
"Stand", "by", "me", "oh", "stand"," by"," me",
  };

	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
