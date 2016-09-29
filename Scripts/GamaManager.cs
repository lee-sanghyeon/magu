using UnityEngine;
using System.Collections;

public class GamaManager : MonoBehaviour {

    public static GamaManager instance=null;

    public bool IsRedteamAttack;//--------true일경우 레드팀이 공,블루팀이 수
    public int Ball;
    public int Strike;
    public int Out;
    public bool[] Base=new bool[3];//-----각각 1,2,3루수에 주자가 있나 없나 체크
                                   //-----(선수간 도루,달리기능력이 다르므로 추후 bool이 아닌 다른 클래스로 바꿀 예정)
    

    void Awake()
    {
        //--------------------------------싱글톤 사용하여 GameManager라는 오브젝트는 1개만 유지합니다
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
            Debug.Log(instance);
        }
        else
            Destroy(this.gameObject);
        //--------------------------------싱글톤끝-------------------------------------------------------
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Application.LoadLevel("tempScene");
        }
        else if (Input.GetMouseButton(1))
        {
            Application.LoadLevel("InGameScene");
        }
	}
}
