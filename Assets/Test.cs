using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

        // Use this for initialization
        void Start () {
			int  i;
			//配列を初期化する
			int[] array = {11,22,33,44,55};

			//配列を前から順に表示
			Debug.Log("配列の中身は前から順に、");
			for(i=0;i<5;i++){
				Debug.Log(array[i]);
			}

			//配列を後ろから順に表示
			Debug.Log("逆順に並べると、");
			for(i=4;i>=0;i--){
				Debug.Log(array[i]);
			}
        }
        
        // Update is called once per frame
        void Update () {
        
        }
}