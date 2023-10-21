using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shake : MonoBehaviour
{
    [SerializeField]
    private float progress = 0.0f;
    Vector2 shakerPosition;
    Vector2 newShakerPosition;
    private bool shaking = false;
    [SerializeField]
    private float minimizeBarProgress;
    [SerializeField]
    private bool isShakingDown;
    [SerializeField]
    private Slider slide;

    
    private void Update()
    {
        if (shaking & progress<slide.maxValue)
        {
            DirectionShaker();
            IncreaseBar();
            SetVector();
            
        }    
        slide.value = progress;
    }

    private void OnMouseDown()
    {
        shaking = true;
        shakerPosition = new Vector2(transform.position.x, transform.position.y);
    }

    private void OnMouseUp()
    {
        shaking = false;
    }
    private void DirectionShaker()
    {
        newShakerPosition = new Vector2(transform.position.x, transform.position.y);
        if (shakerPosition.y >= newShakerPosition.y)
        {
            isShakingDown = true;
        }         
        else if(shakerPosition.y <= newShakerPosition.y)
        {
            isShakingDown = false;
        }
           
    }
    private void SetVector()
    {
          shakerPosition = new Vector2(transform.position.x, transform.position.y);
    }
    void IncreaseBar()
    {
        if(isShakingDown)
            progress += (shakerPosition.y - newShakerPosition.y) / minimizeBarProgress;
        else
            progress += -(shakerPosition.y - newShakerPosition.y) / minimizeBarProgress;
    }
}
