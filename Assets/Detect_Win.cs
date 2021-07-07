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
        if ((Big_Tri_One.transform.position.x <= -44.5 && Big_Tri_One.transform.position.x >= -47.5 && Big_Tri_One.transform.position.y <= -52.5 && Big_Tri_One.transform.position.y >= -55.5) || (Big_Tri_One.transform.position.x >= 48.5 && Big_Tri_One.transform.position.x <= 51.5 && Big_Tri_One.transform.position.y <= -53.5 && Big_Tri_One.transform.position.y >= -56.5))
        {
            Debug.Log(Big_Tri_One + "Correct");
            Big_Tri_One_IsCorrect = true;
        }
        else Big_Tri_One_IsCorrect = false;

        if ((Big_Tri_Two.transform.position.x >= 48.5 && Big_Tri_Two.transform.position.x <= 51.5 && Big_Tri_Two.transform.position.y <= -53.5 && Big_Tri_Two.transform.position.y >= -56.5) || (Big_Tri_Two.transform.position.x <= -44.5 && Big_Tri_Two.transform.position.x >= -47.5 && Big_Tri_Two.transform.position.y <= -52.5 && Big_Tri_Two.transform.position.y >= -55.5))
        {
            Debug.Log(Big_Tri_Two + "Correct");
            Big_Tri_Two_IsCorrect = true;
        }
        else Big_Tri_Two_IsCorrect = false;

        if (Mid_Tri.transform.position.x <= -52.5 && Mid_Tri.transform.position.x >= -55.5 && Mid_Tri.transform.position.y <= -72.5 && Mid_Tri.transform.position.y >= -75.5)
        {
            Debug.Log(Mid_Tri + "Correct");
            Mid_Tri_IsCorrect = true;
        }
        else Mid_Tri_IsCorrect = false;

        if ((Parallelogram.transform.position.x <= -19.5 && Parallelogram.transform.position.x >= -22.5 && Parallelogram.transform.position.y <= -52.5 && Parallelogram.transform.position.y >= -55.5) || (Parallelogram.transform.position.x <= -44.5 && Parallelogram.transform.position.x >= -47.5 && Parallelogram.transform.position.y >= 18.5 && Parallelogram.transform.position.y <= 21.5))
        {
            Debug.Log(Parallelogram + "Correct");
            Parallelogram_IsCorrect = true;
        }
        else Parallelogram_IsCorrect = false;

        if ((Sma_Tri_One.transform.position.x <= -18.5 && Sma_Tri_One.transform.position.x >= -21.5 && Sma_Tri_One.transform.position.y >= 17.5 && Sma_Tri_One.transform.position.y <= 20.5) || (Sma_Tri_One.transform.position.x >= 49.5 && Sma_Tri_One.transform.position.x <= 52.5 && Sma_Tri_One.transform.position.y >= 40.5 && Sma_Tri_One.transform.position.y <= 43.5))
        {
            Debug.Log(Sma_Tri_One + "Correct");
            Sma_Tri_One_IsCorrect = true;
        }
        else Sma_Tri_One_IsCorrect = false;

        if ((Sma_Tri_Two.transform.position.x >= 49.5 && Sma_Tri_Two.transform.position.x <= 52.5 && Sma_Tri_Two.transform.position.y >= 40.5 && Sma_Tri_Two.transform.position.y <= 43.5) || (Sma_Tri_Two.transform.position.x <= -18.5 && Sma_Tri_Two.transform.position.x >= -21.5 && Sma_Tri_Two.transform.position.y >= 17.5 && Sma_Tri_Two.transform.position.y <= 20.5))
        {
            Debug.Log(Sma_Tri_Two + "Correct");
            Sma_Tri_Two_IsCorrect = true;
        }
        else Sma_Tri_Two_IsCorrect = false;

        if ((Square.transform.position.x >= 1.5 && Square.transform.position.x <= 4.5 && Square.transform.position.y <= -4.5 && Square.transform.position.y >= -7.5) || (Square.transform.position.x <= -21.5 && Square.transform.position.x >= -24.5 && Square.transform.position.y >= 15.5 && Square.transform.position.y <= 18.5) || (Square.transform.position.x >= 26.5 && Square.transform.position.x <= 29.5 && Square.transform.position.y >= 17.5 && Square.transform.position.y <= 20.5) || (Square.transform.position.x >= 1.5 && Square.transform.position.x <= 4.5 && Square.transform.position.y >= 41.5 && Square.transform.position.y <= 44.5))
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
