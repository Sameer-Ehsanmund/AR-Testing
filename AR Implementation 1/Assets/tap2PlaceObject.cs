using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;

public class tap2PlaceObject : MonoBehaviour
{

    private ARSessionOrigin AROrigin;

    private Pose placementPose;

    private bool isPlacementPoseValid = false;

    void Start()
    {

        AROrigin = FindObjectOfType<ARSessionOrigin>();
    }

    void Update()
    {

        UpdatePlacementPose();
    }

    private void UpdatePlacementPose()
    {

        var screenCentre = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        AROrigin.GetComponent<ARRaycastManager>().Raycast(screenCentre, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
    }
}
