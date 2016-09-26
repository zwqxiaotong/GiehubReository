using UnityEngine;
using System.Collections;

public class ClickClearance : MonoBehaviour {
	int aroundClearanceNumber=0;
	int numberForName;
	int lineNumber=CreatePefebs.singleton.lineNumber;
	int listNumber=CreatePefebs.singleton.listNumber;
	public GameObject aroundClearanceNumber_0;
	public GameObject aroundClearanceNumber_1;
	public GameObject aroundClearanceNumber_2;
	public GameObject aroundClearanceNumber_3;
	public GameObject aroundClearanceNumber_4;
	public GameObject aroundClearanceNumber_5;
	public GameObject aroundClearanceNumber_6;
	public GameObject aroundClearanceNumber_7;
	public GameObject aroundClearanceNumber_8;
	public GameObject BOOMClearance;
	GameObject canvas;

	// Use this for initialization
	void Start () {
		numberForName = System.Convert.ToInt32 (this.gameObject.name);
		int startPointX = CreatePefebs.singleton.startPointX;
		int startPointY = CreatePefebs.singleton.startPointY;
		canvas = new GameObject ();
//		canvas = CreatePefebs.singleton.canvas;
		int jj = numberForName % 10;
		int ii = numberForName / 10;
		canvas=GameObject.Find("MatrixCenter");




		if (CreatePefebs.singleton.clearanceStateArray [numberForName] == 0) {
//			GameObject a0=(GameObject)Instantiate(lei,new Vector3(startpointx+jj*20,startpointy-ii*20,0),this.transform.rotation);
//			a0.transform.SetParent(canvas.transform, false);
			CreatePefebs.singleton.buttonStateArray[numberForName]=10;
		}

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Click_Clearance_1(){
		if (CreatePefebs.singleton.clearanceStateArray [numberForName] == 0) {
			CreatePefebs.singleton.gameOver (0);
		}
		if (CreatePefebs.singleton.buttonStateArray [numberForName] == 9) {
			Click_Clearance_2();
		}
	}


    public void Click_Clearance_2() {
		numberForName=System .Convert .ToInt32( this.gameObject.name);
		if (numberForName / listNumber != 0 && numberForName % listNumber != 0) {
			if (GameObject.Find ("" + (numberForName - (listNumber+1)))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName - (listNumber+1)] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName / listNumber != 0) {
			if (GameObject.Find ("" + (numberForName - listNumber))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName - listNumber] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName / listNumber != 0 && numberForName % listNumber != (listNumber-1)) {
			if (GameObject.Find ("" + (numberForName - (listNumber-1)))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName - (listNumber-1)] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName % listNumber != 0) {
			if (GameObject.Find ("" + (numberForName - 1))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName - 1] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName % listNumber != (listNumber-1)) {
			if (GameObject.Find ("" + (numberForName + 1))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName + 1] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName / listNumber != (lineNumber-1) && numberForName % listNumber != 0) {
			if (GameObject.Find ("" + (numberForName + (listNumber-1)))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName + (listNumber-1)] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName / listNumber != (lineNumber-1)) {
			if (GameObject.Find ("" + (numberForName + listNumber))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName + listNumber] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		if (numberForName / listNumber != (lineNumber-1) && numberForName % listNumber != (listNumber-1)) {
			if (GameObject.Find ("" + (numberForName + (listNumber+1)))) {
				if (CreatePefebs.singleton.clearanceStateArray [numberForName + (listNumber+1)] == 0) {
					aroundClearanceNumber++;
				}
			}
		}
		CreatePefebs.singleton.buttonStateArray [numberForName] = aroundClearanceNumber;
		int startpointx = CreatePefebs.singleton.startPointX;
		int startpointy = CreatePefebs.singleton.startPointY;
		int horizontalImageNumber = numberForName % listNumber;
		int verticalImageNumber = numberForName / listNumber;

		switch (aroundClearanceNumber) {
		case 0:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_0,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
			replaceImage.transform.SetParent(canvas.transform, false);
				if (numberForName / listNumber != 0 && numberForName % listNumber != 0) {
					if(GameObject.Find ("" + (numberForName - (listNumber+1)))&&CreatePefebs.singleton.buttonStateArray[numberForName-(listNumber+1)]==9){
						GameObject.Find(""+(numberForName-(listNumber+1))).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if (numberForName / listNumber != 0) {
					if(GameObject.Find(""+(numberForName-listNumber))&&CreatePefebs.singleton.buttonStateArray[numberForName-listNumber]==9){
						GameObject.Find(""+(numberForName-listNumber)).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if (numberForName / listNumber != 0 && numberForName % listNumber != (listNumber-1)) {
					if(GameObject.Find(""+(numberForName-(listNumber-1)))&&CreatePefebs.singleton.buttonStateArray[numberForName-(listNumber-1)]==9){
						GameObject.Find(""+(numberForName-(listNumber-1))).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if (numberForName % listNumber != 0) {
					if(GameObject.Find(""+(numberForName-1))&&CreatePefebs.singleton.buttonStateArray[numberForName-1]==9){
						GameObject.Find(""+(numberForName-1)).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if(numberForName % listNumber != (listNumber-1)){
					if(GameObject.Find(""+(numberForName+1))&&CreatePefebs.singleton.buttonStateArray[numberForName+1]==9){
						GameObject.Find(""+(numberForName+1)).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if (numberForName / listNumber != (lineNumber-1) && numberForName % listNumber != 0) {
					if(GameObject.Find(""+(numberForName+(listNumber-1)))&&CreatePefebs.singleton.buttonStateArray[numberForName+(listNumber-1)]==9){
						GameObject.Find(""+(numberForName+(listNumber-1))).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if (numberForName / listNumber != (lineNumber-1)) {
					if(GameObject.Find(""+(numberForName+listNumber))&&CreatePefebs.singleton.buttonStateArray[numberForName+listNumber]==9){
						GameObject.Find(""+(numberForName+listNumber)).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}

				if (numberForName / listNumber != (lineNumber-1) && numberForName % listNumber != (listNumber-1)) {
					if(GameObject.Find(""+(numberForName+(listNumber+1)))&&CreatePefebs.singleton.buttonStateArray[numberForName+(listNumber+1)]==9){
						GameObject.Find(""+(numberForName+(listNumber+1))).GetComponent<ClickClearance>().Click_Clearance_1();
				}
			}
		}

			break;
		case 1:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_1,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);}

			break;
		case 2:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_2,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);}

			break;
		case 3:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_3,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);
		}
			break;
		case 4:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_4,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);
			        }
			break;
		case 5:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_5,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);
		}
			break;
		case 6:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_6,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);
		}
			break;
		case 7:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_7,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);
		}
			break;
		case 8:{GameObject replaceImage=(GameObject)Instantiate(aroundClearanceNumber_8,new Vector3(startpointx+horizontalImageNumber*20,startpointy-verticalImageNumber*20,0),this.transform.rotation);
				replaceImage.transform.SetParent(canvas.transform, false);
		}
			break;
		}
		CreatePefebs.singleton.notHaveClearance--;
		if (CreatePefebs.singleton.notHaveClearance == 0) {
			CreatePefebs.singleton.gameOver (1);
		}
		Destroy (this.gameObject);
    }
}
