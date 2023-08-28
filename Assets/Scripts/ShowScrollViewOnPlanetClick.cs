using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScrollViewOnPlanetClick : MonoBehaviour
{
    public GameObject scrollView;


    // Start is called before the first frame update
    private void Start()
    {
        scrollView.SetActive(false); // hide the scroll view initially
    }

    public void ShowScrollView()
    {
        scrollView.SetActive(true);  // Show the scroll view
    }

    public void HideScrollView()
    {
        scrollView.SetActive(false);  // Hide the scroll View
    }


}
