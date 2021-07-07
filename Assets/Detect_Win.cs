using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Detect_Win : MonoBehaviour
{
    public GameObject Big_Tri_One;
    public GameObject Big_Tri_Two;
    public GameObject Mid_Tri;
    public GameObject Sma_Tri_One;
    public GameObject Sma_Tri_Two;
    public GameObject Parallelogram;
    public GameObject Square;
    private bool Big_Tri_One_IsCorrect = false;
    private bool Big_Tri_Two_IsCorrect = false;
    private bool Mid_Tri_IsCorrect = false;
    private bool Sma_Tri_One_IsCorrect = false;
    private bool Sma_Tri_Two_IsCorrect = false;
    private bool Parallelogram_IsCorrect = false;
    private bool Square_IsCorrect = false;
    public GameObject Win_Msg;
    public GameObject Err_Msg;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Big_Tri_One_IsCorrect && Big_Tri_Two_IsCorrect && Mid_Tri_IsCorrect && Sma_Tri_One_IsCorrect && Sma_Tri_Two_IsCorrect && Parallelogram_IsCorrect && Square_IsCorrect) {
            Debug.Log("You Win");
            Win_Msg.SetActive(true);
            Err_Msg.SetActive(false);
            SceneManager.LoadScene(1);

        }
        
    }
    public void detect() {
        if ((Big_Tri_One.transform.position.x <= 34 && Big_Tri_One.transform.position.x >= 28 && Big_Tri_One.transform.position.y <= -3.5 && Big_Tri_One.transform.position.y >= -9.5) || (Big_Tri_One.transform.position.x >= -0.5 && Big_Tri_One.transform.position.x <= 5.5 && Big_Tri_One.transform.position.y <= -31 && Big_Tri_One.transform.position.y >= -37))
        {
            Debug.Log(Big_Tri_One + "Correct");
            Big_Tri_One_IsCorrect = true;
        }
        else Big_Tri_One_IsCorrect = false;

        if ((Big_Tri_Two.transform.position.x <= 34 && Big_Tri_Two.transform.position.x >= 28 && Big_Tri_Two.transform.position.y <= -3.5 && Big_Tri_Two.transform.position.y >= -9.5) || (Big_Tri_Two.transform.position.x >= -0.5 && Big_Tri_Two.transform.position.x <= 5.5 && Big_Tri_Two.transform.position.y <= -31 && Big_Tri_Two.transform.position.y >= -37))
        {
            Debug.Log(Big_Tri_Two + "Correct");
            Big_Tri_Two_IsCorrect = true;
        }
        else Big_Tri_Two_IsCorrect = false;

        if (Mid_Tri.transform.position.x <= -29 && Mid_Tri.transform.position.x >= -35 && Mid_Tri.transform.position.y <= 32.5 && Mid_Tri.transform.position.y >= 26.5)
        {
            Debug.Log(Mid_Tri + "Correct");
            Mid_Tri_IsCorrect = true;
        }
        else Mid_Tri_IsCorrect = false;

        if ((Parallelogram.transform.position.x <= -30 && Parallelogram.transform.position.x >= -36 && Parallelogram.transform.position.y <= -13.5 && Parallelogram.transform.position.y >= -19.5))
        {
            Debug.Log(Parallelogram + "Correct");
            Parallelogram_IsCorrect = true;
        }
        else Parallelogram_IsCorrect = false;

        if ((Sma_Tri_One.transform.position.x <= -7.5 && Sma_Tri_One.transform.position.x >= -13.5 && Sma_Tri_One.transform.position.y >= -8 && Sma_Tri_One.transform.position.y <= -2) || (Sma_Tri_One.transform.position.x >= 24 && Sma_Tri_One.transform.position.x <= 30 && Sma_Tri_One.transform.position.y >= 30 && Sma_Tri_One.transform.position.y <= 36))
        {
            Debug.Log(Sma_Tri_One + "Correct");
            Sma_Tri_One_IsCorrect = true;
        }
        else Sma_Tri_One_IsCorrect = false;

        if ((Sma_Tri_Two.transform.position.x <= -7.5 && Sma_Tri_Two.transform.position.x >= -13.5 && Sma_Tri_Two.transform.position.y >= -8 && Sma_Tri_Two.transform.position.y <= -2) || (Sma_Tri_Two.transform.position.x >= 24 && Sma_Tri_Two.transform.position.x <= 30 && Sma_Tri_Two.transform.position.y >= 30 && Sma_Tri_Two.transform.position.y <= 36))
        {
            Debug.Log(Sma_Tri_Two + "Correct");
            Sma_Tri_Two_IsCorrect = true;
        }
        else Sma_Tri_Two_IsCorrect = false;

        if ((Square.transform.position.x >= -0.5 && Square.transform.position.x <= 5.5 && Square.transform.position.y <= 21.5 && Square.transform.position.y >= 15.5))
        {
            Debug.Log(Square + "Correct");
            Square_IsCorrect = true;
        }
        else Square_IsCorrect = false;

        if (!Big_Tri_One_IsCorrect || !Big_Tri_Two_IsCorrect || !Mid_Tri_IsCorrect || !Sma_Tri_One_IsCorrect || !Sma_Tri_Two_IsCorrect || !Parallelogram_IsCorrect || !Square_IsCorrect)
        {
            StartCoroutine(ShowMsg());
        }


    }
    IEnumerator ShowMsg() {
        Err_Msg.SetActive(true);
        yield return new WaitForSeconds(3f);
        Err_Msg.SetActive(false);
    }
}
