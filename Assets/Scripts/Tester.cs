using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour {

	// Use this for initialization
	void Start () {

        /*
        CoHo.Instance.WaitAndCallback ( 3, ( ) => 
        {
            Debug.Log ( "hell yeah ddude" );
        } );
        */

        /*
        this.DoWhen ( ( ) => 
        {
            return Input.GetMouseButton ( 0 );
        }, ( ) => 
        {
            Debug.Log ( "clicked!" );
        } );
        */

        this.PlayAll(
            new IEnumerator [ ] {
                MouseClickCoroutine(1),
                MouseClickCoroutine(0),
                KeyClickCoroutine(KeyCode.I),
                KeyClickCoroutine(KeyCode.J)
        });
        
	}

    private IEnumerator MouseClickCoroutine (int mouseButton)
    {
        return CoHoExtensions.Co_DoWhen ( ( ) =>
        {
            return Input.GetMouseButton ( mouseButton );
        }, ( ) =>
        {
            Debug.Log ( "we pressed mouse " + mouseButton );
        } );
    }

    private IEnumerator KeyClickCoroutine (KeyCode keycode)
    {
        return CoHoExtensions.Co_DoWhen ( ( ) =>
        {
            return Input.GetKey ( keycode );
        },()=>
        {
            Debug.Log ( "we pressed " + keycode );
        } );
    }

	// Update is called once per frame
	void Update () {
		
	}
}
