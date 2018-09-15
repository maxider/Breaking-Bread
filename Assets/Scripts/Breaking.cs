using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaking : MonoBehaviour
{

    public GameObject background;
    public GameObject hitBox;
    public GameObject movingThing;

    public GameObject Jesus;

    float speed = 3f;
    int direction = 1; // 1 = right -1 = left

    float rightLimit;
    float leftLimit;

    float rightHitBoxBounds;
    float leftHitBoxBounds;

    Vector2 movingThingPos;

    float colorDuration = 0.5f;
    float colorTimer;
    bool isJesusColored = false;
    Color originalJesusColor;

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        rightLimit = (background.transform.position.x + background.transform.localScale.x / 2) * movingThing.transform.parent.transform.localScale.x;
        leftLimit = (background.transform.position.x - background.transform.localScale.x / 2) * movingThing.transform.parent.transform.localScale.x;

        rightHitBoxBounds = (hitBox.transform.position.x + hitBox.transform.localScale.x) * movingThing.transform.parent.transform.localScale.x;
        leftHitBoxBounds = (hitBox.transform.position.x - hitBox.transform.localScale.x) * movingThing.transform.parent.transform.localScale.x;

        movingThing.transform.position = new Vector2(rightLimit, movingThing.transform.position.y);
        direction = 1;

        colorTimer = colorDuration;
        originalJesusColor = Jesus.GetComponent<SpriteRenderer>().color;

        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        movingThingPos = movingThing.transform.position;
        movingThingPos.x += speed * Time.deltaTime * direction;
        movingThing.transform.position = movingThingPos;
        if (movingThing.transform.position.x > rightLimit)
        {
            direction *= -1;
        }
        else if (movingThing.transform.position.x < leftLimit)
        {
            direction *= -1;
        }

        if(isJesusColored)
        {
            colorTimer -= Time.deltaTime;
            if (colorTimer <= 0)
            {
                colorTimer = colorDuration;
                resetJesus();
            }
        }
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
            direction = 1;
            colorJesus();
            audioSource.Play();
        }
    }

    void colorJesus()
    {
        Jesus.GetComponent<SpriteRenderer>().color = Color.red;
        isJesusColored = true;
    }

    void resetJesus()
    {
        Jesus.GetComponent<SpriteRenderer>().color = originalJesusColor;
        isJesusColored = false;
    }
}
