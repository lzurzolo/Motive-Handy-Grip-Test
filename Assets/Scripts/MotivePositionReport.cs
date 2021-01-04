using System;
using LibHandyGrip;
using UnityEngine;

public class MotivePositionReport : MonoBehaviour
{
    public int MarkerID { get; set; }
    private string FingerPosition;
    private HandyGripHand _hand;
    private Transform _transform;

    private void Start()
    {
        _hand = GameObject.Find("HandyGripHand").GetComponent<HandyGripHand>();
        if(MarkerID == 273)
        {
            FingerPosition = "IndexTip";
            _transform = transform;
            _hand.SetTipReference(FingerType.Index, _transform);
        }
        else if(MarkerID == 2050)
        {
            //FingerPosition = "IndexMiddle";
            //_transform = transform;
            //_hand.SetBoneReference(FingerType.Index, BoneType.Distal, _transform);
        }
        else if(MarkerID == 546)
        {
            //FingerPosition = "IndexBase";
            //_transform = transform;
            //_hand.SetBoneReference(FingerType.Index, BoneType.Metacarpal, _transform);
        }
        else if(MarkerID == 1092)
        {
            FingerPosition = "ThumbTip";
            _transform = transform;
            _hand.SetTipReference(FingerType.Thumb, _transform);
        }
        else if(MarkerID == 2184)
        {
            //FingerPosition = "ThumbMiddle";
            //_transform = transform;
            //_hand.SetBoneReference(FingerType.Thumb, BoneType.Distal, _transform);
        }
        else if(MarkerID == 137)
        {
            //FingerPosition = "ThumbBase";
            //_transform = transform;
            //_hand.SetBoneReference(FingerType.Thumb, BoneType.Metacarpal, _transform);
        }
        else if(MarkerID == 145)
        {
            //FingerPosition = "Wrist";
            //_hand.wrist = transform;
        }
        else if(MarkerID == 2560)
        {
            //FingerPosition = "ThumbIndexBase";
        }
        else
        {
            FingerPosition = null;
        }
    }
	
    private void Update()
    {
        _transform = transform;
    }

    private void OnDestroy()
    {
        if (MarkerID == 273) _hand.SetTipReference(FingerType.Index, _hand.nullTransform);
        else if (MarkerID == 1092) _hand.SetTipReference(FingerType.Thumb, _hand.nullTransform);
    }
}