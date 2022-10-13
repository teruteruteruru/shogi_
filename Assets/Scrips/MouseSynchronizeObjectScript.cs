using UnityEngine;
using System.Collections;

public class MouseSynchronizeObjectScript : MonoBehaviour
{
	// �ʒu���W
	private Vector3 position;
	// �X�N���[�����W�����[���h���W�ɕϊ������ʒu���W
	private Vector3 screenToWorldPointPosition;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		// Vector3�Ń}�E�X�ʒu���W���擾����
		position = Input.mousePosition;
		// Z���C��
		position.z = 10f;
		// �}�E�X�ʒu���W���X�N���[�����W���烏�[���h���W�ɕϊ�����
		screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		// ���[���h���W�ɕϊ����ꂽ�}�E�X���W����
		gameObject.transform.position = screenToWorldPointPosition;
	}
}