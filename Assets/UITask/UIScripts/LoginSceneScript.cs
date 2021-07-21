using System;
using System.Collections;
using System.Collections.Generic;

// using System.Diagnostics;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginSceneScript : MonoBehaviour
{

    public InputField idinput;
    public InputField pwinout;
    public Text title;
    public string Userid, Password;
    public Text IDtext;
    public Text PWtext;
    public void LoginCheck()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RegisterCheck()
    {
        Console.WriteLine("RegisterCheck!");
    }

    public void Exitgame()
    {
        Application.Quit();
    }
    
    public void  Changed_Value(string inp){

        print ("正在输入:"+inp);

    }
    
    public void  End_Value(string inp){

        print ("文本内容:"+inp);

    }
    // Start is called before the first frame update
    //GameObject idtext = GameObject.Find("ID Text");
    public int rannum()
    {
        RNGCryptoServiceProvider csp =new RNGCryptoServiceProvider();
        byte[] byteCsp =new byte[10];
        csp.GetBytes(byteCsp);
        // Console.WriteLine(BitConverter.ToInt());
        // Debug.Log(BitConverter.ToString(byteCsp).ToString());
        int result = System.Math.Abs(BitConverter.ToInt32(byteCsp, 0) % 255);
        // Debug.Log(result);
        // Debug.Log(BitConverter.ToInt32(byteCsp,0)%255.GetType() );
        return result;
    }
    void Start()
    {
        // transform.GetComponent<InputField>().onValueChanged.AddListener (Changed_Value);
        // transform.GetComponent<InputField>().onEndEdit.AddListener (End_Value);
        rannum();
    }
    
    
    // Update is called once per frame
    void Update()
    {
        // IDtext.color = new Color32(50, 120, 255, 255);
        title.color = new Color32(50, 120, 255, 255);
        // PWtext.color = new Color32(50, 197, rannum(), 255);
    }
}


