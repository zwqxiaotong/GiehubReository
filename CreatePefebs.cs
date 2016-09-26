using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CreatePefebs : MonoBehaviour {
    public static CreatePefebs singleton;
    GameObject canvas;
    public GameObject clearancePrefeb;
    public int[] clearanceStateArray;//
	public int[] buttonStateArray;
    public int lineNumber;
    public int listNumber;
	public int notHaveClearance;
    public int startPointX = 0;
    public int startPointY = 0;

	// Use this for initialization
	void Start () {
		lineNumber = 14;
		listNumber = 20;
		singleton = this;
		canvas = GameObject.Find ("MatrixCenter");
        startPointX = -listNumber * 20 / 2 + 20 / 2;
        startPointY = lineNumber * 20 / 2 - 20 / 2;
        clearanceStateArray = new int[lineNumber * listNumber];
		buttonStateArray = new int[lineNumber * listNumber];
		int lattice = lineNumber * listNumber;
		int clearancePrintNumber = System.Convert.ToInt32 (GameObject.Find ("Text_ClearanceNumber").GetComponent<Text> ().text);
		print (clearancePrintNumber);
		int clearance = 30;
		notHaveClearance = listNumber * lineNumber - clearance;
		for(int i = 0; i < lineNumber; i++)
        {
			for (int j = 0; j < listNumber; j++)
            {
                GameObject initializeClearance= (GameObject)Instantiate(clearancePrefeb, new Vector3(startPointX + 20 * j, startPointY - 20 * i, 0), clearancePrefeb.transform.rotation);
				initializeClearance.gameObject.name=(i*listNumber+j).ToString();
                initializeClearance.transform.SetParent(canvas.transform, false);
				if(clearance==0){
					clearanceStateArray[i*listNumber+j]=1;
				}else if(lattice>clearance){
					clearanceStateArray[i*listNumber+j]=Random.Range(0,(int)(lattice/clearance));
				}else{
					clearanceStateArray[i*listNumber+j]=0;
				}
				lattice--;
				if(clearanceStateArray[i*listNumber+j]==0){
					clearance--;
					print(i*listNumber+j);
				}
				buttonStateArray[i*listNumber+j]=9;
            }
        }
	}

	public void 

	public void gameOver(int i){
		if (i == 1) {
			GameObject.Find ("Again_Button").GetComponent<Image> ().color = new Color (0, 1, 100 / 255f);
		} else {
			GameObject.Find ("Again_Button").GetComponent<Image> ().color = new Color (1, 70 / 255f, 70 / 255f);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

}
