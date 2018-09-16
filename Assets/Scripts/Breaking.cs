using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Breaking : MonoBehaviour
{

    public GameObject background;
    public GameObject hitBox;
    public GameObject movingThing;

    public GameObject Jesus;
    Animator jesusAnimator;

    float speed = 14f;
    bool right = true;

    float rightLimit;
    float leftLimit;

    float rightHitBoxBounds;
    float leftHitBoxBounds;

    float sizeMult;

    Vector2 movingThingPos;

    float colorDuration = 0.5f;
    float colorTimer;
    bool isJesusColored = false;
    Color originalJesusColor;

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        initMovingThing();

        initJesusColor();
        jesusAnimator = Jesus.GetComponent<Animator>();

        initAudio();
    }

    // Update is called once per frame
    void Update()
    {
        movingThingLogic();

        jesusColorLogic();
    }

    public void ButtonPress()
    {
        if (movingThing.transform.position.x <= rightHitBoxBounds && movingThing.transform.position.x >= leftHitBoxBounds)
        {
            //insdie hitbox Logic
            PlayerInfo.BrokenBreadAmount++;
        }
        else
        {
            //outside of hitbox logic
            movingThing.transform.position = new Vector2(leftLimit, movingThing.transform.position.y);
            right = true;
            colorJesus();
            jesusAnimator.SetTrigger("JesusHit");
            audioSource.Play();
        }
    }

    void initMovingThing()
    {
        sizeMult = movingThing.transform.parent.transform.localScale.x * movingThing.transform.parent.transform.parent.GetComponent<RectTransform>().localScale.x;

        rightLimit = (background.transform.position.x + background.transform.localScale.x / 2) * sizeMult;
        leftLimit = (background.transform.position.x - background.transform.localScale.x / 2) * sizeMult;

        rightHitBoxBounds = (hitBox.transform.position.x + hitBox.transform.localScale.x) * sizeMult;
        leftHitBoxBounds = (hitBox.transform.position.x - hitBox.transform.localScale.x) * sizeMult;

        movingThing.transform.position = new Vector2(rightLimit, movingThing.transform.position.y);

        speed *= sizeMult;
        right = true;

    }

    void initJesusColor()
    {
        colorTimer = colorDuration;
        originalJesusColor = Jesus.GetComponent<Image>().color;
    }

    void initAudio()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.3f;
    }

    void movingThingLogic()
    {
        movingThingPos = movingThing.transform.position;
        movingThingPos.x += speed * Time.deltaTime * (right ? 1 : -1);
        movingThing.transform.position = movingThingPos;
        if (movingThing.transform.position.x > rightLimit)
        {
            right = false;
        }
        else if (movingThing.transform.position.x < leftLimit)
        {
            right = true;
        }
    }

    void jesusColorLogic()
    {
        if (isJesusColored)
        {
            colorTimer -= Time.deltaTime;
            if (colorTimer <= 0)
            {
                colorTimer = colorDuration;
                resetJesus();
            }
        }
    }

    void colorJesus()
    {
        Jesus.GetComponent<Image>().color = Color.red;
        isJesusColored = true;
    }

    void resetJesus()
    {
        Jesus.GetComponent<Image>().color = originalJesusColor;
        isJesusColored = false;
    }
}
