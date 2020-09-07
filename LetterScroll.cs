using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;


//letter selection for 3-letter initial entry on high score table
public class LetterScroll : MonoBehaviour
{

    public Text scoreText;

    float lastStep, timeBetweenSteps = 0.5f;
    
    private int selectedLetterIndex;

    [SerializeField]
    public List<string> letters = new List<string>();
    
    public float coolDown = 0.5f;

    public GameObject letterSelect1;
    public GameObject letterSelect2;
    public GameObject letterSelect3;

    public Text letter1;
    public Text letter2;
    public Text letter3;

    bool canChange1 = true;
    bool canChange2 = true;
    bool canChange3 = true;

    bool initial1 = true;
    bool initial2 = false;
    bool initial3 = false;


void Start()
    {
        //set first letter entry active
        letterSelect1.SetActive(true);
        letterSelect2.SetActive(false);
        letterSelect3.SetActive(false);

        selectedLetterIndex = 0;

        letter1.text = letters[selectedLetterIndex];
        letter2.text = letters[selectedLetterIndex];
        letter3.text = letters[selectedLetterIndex];

    }



    void FixedUpdate()
    {
        
        ScrollUp();
        ScrollUp2();
        ScrollUp3();
        ScrollDown();
        ScrollDown2();
        ScrollDown3();
        Submit();
        
    }


//scroll up for letter1
    void ScrollUp()
    {

        if (Input.GetButton("ScrollUp") && canChange1)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    selectedLetterIndex++;

                    if (selectedLetterIndex < 0)
                    {
                        selectedLetterIndex = 25;
                    }

                    if (selectedLetterIndex > 25)
                    {
                        selectedLetterIndex = 0;
                    }

                    Debug.Log(selectedLetterIndex);

                    letter1.text = letters[selectedLetterIndex];

                }
            }

        }

    }


//scroll up for letter2
    void ScrollUp2()
    {

        if (Input.GetButton("ScrollUp") && canChange2)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    selectedLetterIndex++;

                    if (selectedLetterIndex < 0)
                    {
                        selectedLetterIndex = 25;
                    }

                    if (selectedLetterIndex > 25)
                    {
                        selectedLetterIndex = 0;
                    }

                    Debug.Log(selectedLetterIndex);

                    letter2.text = letters[selectedLetterIndex];

                }
            }

        }

    }

//scroll up for letter3
    void ScrollUp3 ()
    {

        if (Input.GetButton("ScrollUp") && canChange3)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    selectedLetterIndex++;

                    if (selectedLetterIndex < 0)
                    {
                        selectedLetterIndex = 25;
                    }

                    if (selectedLetterIndex > 25)
                    {
                        selectedLetterIndex = 0;
                    }

                    Debug.Log(selectedLetterIndex);

                    letter3.text = letters[selectedLetterIndex];

                }
            }

        }

    }


//scroll down for letter1
    void ScrollDown()
    {

        if (Input.GetButton("ScrollDown") && canChange1)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    selectedLetterIndex--;

                    if (selectedLetterIndex < 0)
                    {
                        selectedLetterIndex = 25;
                    }

                    if (selectedLetterIndex > 25)
                    {
                        selectedLetterIndex = 0;
                    }


                    Debug.Log(selectedLetterIndex);
                    letter1.text = letters[selectedLetterIndex];
                }
            }
                   
        }

    }

//scroll down for letter2
    void ScrollDown2()
    {

        if (Input.GetButton("ScrollDown") && canChange2)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    selectedLetterIndex--;

                    if (selectedLetterIndex < 0)
                    {
                        selectedLetterIndex = 25;
                    }

                    if (selectedLetterIndex > 25)
                    {
                        selectedLetterIndex = 0;
                    }


                    Debug.Log(selectedLetterIndex);
                    letter2.text = letters[selectedLetterIndex];
                }
            }

        }

    }

//scroll dwon for letter3
    void ScrollDown3()
    {

        if (Input.GetButton("ScrollDown") && canChange3)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    selectedLetterIndex--;

                    if (selectedLetterIndex < 0)
                    {
                        selectedLetterIndex = 25;
                    }

                    if (selectedLetterIndex > 25)
                    {
                        selectedLetterIndex = 0;
                    }


                    Debug.Log(selectedLetterIndex);
                    letter3.text = letters[selectedLetterIndex];
                }
            }

        }

    }


//submitting for each individual letter
    void Submit()
    {
        //submit letter1
        if (Input.GetButton("Submit") && initial1)
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    initial1 = false;
                    canChange1 = false;

                    letterSelect2.SetActive(true);

                    initial2 = true;
                    canChange2 = true;
                    

                    Debug.Log("Submit");
                    selectedLetterIndex = 0;
                }
            }
        }


        //submit letter2
        else
        if (Input.GetButton("Submit") && initial2)
        {
                    if (Time.time - lastStep > timeBetweenSteps)
                    {
                        lastStep = Time.time;
                        {
                            initial2 = false;
                            canChange2 = false;

                            letterSelect3.SetActive(true);

                            initial3 = true;
                            canChange3 = true;

                            Debug.Log("Submit2");
                            selectedLetterIndex = 0;
                        }
                    }
        }       

        //submit letter3
        else
        if (Input.GetButton("Submit") && initial3) 
        {
            if (Time.time - lastStep > timeBetweenSteps)
            {
                lastStep = Time.time;
                {
                    string playerName = letter1.text + letter2.text + letter3.text;
                    string score = scoreText.text.ToString();
                    Debug.Log(score);
                    Debug.Log(playerName);

                    initial3 = false;

                    canChange3 = false;

                    Debug.Log("Submit3");
                    
                }
            }
        }

    }

//CoolDown is meant to create a brief pause between each letter. without cooldown letters scroll too quickly
    void CooledDown1()
    {
        canChange1 = true;
        canChange2 = false;
        canChange3 = false;
    }



    void CooledDown2()
    {
        canChange1 = false;
        canChange2 = true;
        canChange3 = false;
    }



    void CooledDown3()
    {
        canChange1 = false;
        canChange2 = false;
        canChange3 = true;
    }


//serialize letter entry
    [SerializeField] private newScoreEntry _newScoreEntry = new newScoreEntry();
    public void SaveIntoJson()
    {
        string scoreboardList = JsonUtility.ToJson(_newScoreEntry);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/newScoreEntry.json", scoreboardList);
        Debug.Log(scoreboardList);
    }


    [System.Serializable]
    public class newScoreEntry
    {
        public string playerName;
        public string score;
    }


}





