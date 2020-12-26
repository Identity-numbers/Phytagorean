using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Main : MonoBehaviour {

    public InputField inputfield;
    public float currLength = 1;
    public List<float> divList = new List<float> ();
    public int getLength = 20;

    // Start is called before the first frame update
    void Start () {
        getDivList ();
    }

    public void getDivList () {

        for (int i = 0; i < getLength; i++) {
            //add curr value to list
            float getCurrLengthForList = Mathf.Floor (1f / currLength);
            divList.Add (getCurrLengthForList);
            //get new length and store in currLenght
            float newLength = Mathf.Sqrt (2*Mathf.Pow (currLength / 2, 2));
            currLength = newLength;
        }
        PrintToTxtField ();
    }

    public void PrintToTxtField () {

    }

}