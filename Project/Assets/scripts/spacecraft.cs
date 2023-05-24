using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class spacecraft : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public ads adunitid;
    public Player logic;
    public Image s1;
    public Image s2;
    public Image s3;
    public Image s4;
    public Image s5;
    public Image s6;
    public Image s7;
    public Image s8;
    public Image s9;


    public SpriteRenderer spacecraft1;
    public GameObject music;
    public GameObject pausebutton;

    public static int tscore;
    public Text money;
    

    public float speed;
    public Text finalscore;
    public Rigidbody2D rigidbody1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(1600/720 - Screen.width/Screen.height );

        if (PlayerPrefs.GetInt("ads removed", 0) == 0)
        {
            adunitid = GameObject.FindGameObjectWithTag("ad").GetComponent<ads>();
        }

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Player>();
        rigidbody1 = gameObject.GetComponent<Rigidbody2D>();
        tscore = PlayerPrefs.GetInt("total score", 0);
      

    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerPrefs.GetInt("spacecraft", 0) == 0)
        {
            spacecraft1.sprite = s1.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 1)
        {

            spacecraft1.sprite = s2.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 2)
        {
            spacecraft1.sprite = s3.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 3)
        {
            spacecraft1.sprite = s4.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 4)
        {
            spacecraft1.sprite = s5.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 5)
        {
            spacecraft1.sprite = s6.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 6)
        {
            spacecraft1.sprite = s7.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 7)
        {
            spacecraft1.sprite = s8.sprite;
        }
        if (PlayerPrefs.GetInt("spacecraft", 0) == 8)
        {
            spacecraft1.sprite = s9.sprite;
        }
        if (transform.position.x <= -6.2- 1600 /(1.0* 720) + Screen.width / (1.0 *Screen.height) && transform.position.x >= -24.2+ 1600 / (1.0 * 720) - Screen.width / (1.0 * Screen.height) && pausebutton.activeSelf==false )
        {
            if (SystemInfo.deviceType == DeviceType.Handheld)
            {
                if (Input.touchCount > 0)
                {
                    Touch touch = Input.GetTouch(0);
                    if (touch.phase == TouchPhase.Stationary)
                    {
                        if (touch.position.x < Screen.width / 2)
                        {
                            //rigidbody1.AddForce(transform.right * -100 * speed);
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 0)
                            {
                                rigidbody1.AddForce(transform.right * -100 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 1)
                            {
                                rigidbody1.AddForce(transform.right * -110 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 2)
                            {
                                rigidbody1.AddForce(transform.right * -120 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 3)
                            {
                                rigidbody1.AddForce(transform.right * -130 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 4)
                            {
                                rigidbody1.AddForce(transform.right * -140 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 5)
                            {
                                rigidbody1.AddForce(transform.right * -150 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 6)
                            {
                                rigidbody1.AddForce(transform.right * -160 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 7)
                            {
                                rigidbody1.AddForce(transform.right * -170 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 8)
                            {
                                rigidbody1.AddForce(transform.right * -180 * speed);
                            }

                        }
                        else if (touch.position.x > Screen.width / 2)
                        {
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 0)
                            {
                                rigidbody1.AddForce(transform.right * 100 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 1)
                            {
                                rigidbody1.AddForce(transform.right * 110 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 2)
                            {
                                rigidbody1.AddForce(transform.right * 120 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 3)
                            {
                                rigidbody1.AddForce(transform.right * 130 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 4)
                            {
                                rigidbody1.AddForce(transform.right * 140 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 5)
                            {
                                rigidbody1.AddForce(transform.right * 150 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 6)
                            {
                                rigidbody1.AddForce(transform.right * 160 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 7)
                            {
                                rigidbody1.AddForce(transform.right * 170 * speed);
                            }
                            if (PlayerPrefs.GetInt("spacecraft", 0) == 8)
                            {
                                rigidbody1.AddForce(transform.right * 180 * speed);
                            }
                        }

                    }
                }
            }

            if (SystemInfo.deviceType == DeviceType.Desktop)
            {
                if (Input.GetMouseButton(0))
                {
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 0)
                    {
                        rigidbody1.AddForce(transform.right * -100 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 1)
                    {
                        rigidbody1.AddForce(transform.right * -110 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 2)
                    {
                        rigidbody1.AddForce(transform.right * -120 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 3)
                    {
                        rigidbody1.AddForce(transform.right * -130 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 4)
                    {
                        rigidbody1.AddForce(transform.right * -140 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 5)
                    {
                        rigidbody1.AddForce(transform.right * -150 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 6)
                    {
                        rigidbody1.AddForce(transform.right * -160 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 7)
                    {
                        rigidbody1.AddForce(transform.right * -170 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 8)
                    {
                        rigidbody1.AddForce(transform.right * -180 * speed);
                    }
                }

                else if (Input.GetMouseButton(1))
                {
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 0)
                    {
                        rigidbody1.AddForce(transform.right * 100 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 1)
                    {
                        rigidbody1.AddForce(transform.right * 110 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 2)
                    {
                        rigidbody1.AddForce(transform.right * 120 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 3)
                    {
                        rigidbody1.AddForce(transform.right * 130 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 4)
                    {
                        rigidbody1.AddForce(transform.right * 140 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 5)
                    {
                        rigidbody1.AddForce(transform.right * 150 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 6)
                    {
                        rigidbody1.AddForce(transform.right * 160 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 7)
                    {
                        rigidbody1.AddForce(transform.right * 170 * speed);
                    }
                    if (PlayerPrefs.GetInt("spacecraft", 0) == 8)
                    {
                        rigidbody1.AddForce(transform.right * 180 * speed);
                    }
                }
            }
        }
        else if (transform.position.x > -24.2+ 1600 / (1.0 * 720) - Screen.width / (1.0 * Screen.height))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        else if (transform.position.x < -6.2- 1600 / (1.0 * 720) + Screen.width / (1.0 * Screen.height))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
       
    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        finalscore.text = logic.score.ToString();
        logic.t = false;
        music.SetActive(false);
        if (PlayerPrefs.GetInt("ads removed", 0) == 0)
        {
            Advertisement.Show(adunitid._adUnitId, this);
            Advertisement.Load(adunitid._adUnitId, this);
        }



    }
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        // Optionally execute code if the Ad Unit successfully loads content.
    }

    public void OnUnityAdsFailedToLoad(string _adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit: {_adUnitId} - {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to load, such as attempting to try again.
    }
    public void OnUnityAdsShowFailure(string _adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {_adUnitId}: {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to show, such as loading another ad.
    }
    public void OnUnityAdsShowStart(string _adUnitId) { }
    public void OnUnityAdsShowClick(string _adUnitId) { }
    public void OnUnityAdsShowComplete(string _adUnitId, UnityAdsShowCompletionState showCompletionState) { }
}