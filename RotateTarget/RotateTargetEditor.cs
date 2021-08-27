using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RotateTarget))]//拡張するクラスを指定
public class RotateTargetEditor : Editor {

  /// <summary>
  /// InspectorのGUIを更新
  /// </summary>
  public override void OnInspectorGUI(){
    //元のInspector部分を表示
    base.OnInspectorGUI ();

    //targetを変換して対象を取得
    RotateTarget m_RotateTarget = target as RotateTarget;

    if (GUILayout.Button("再生")){
        m_RotateTarget.IsPlaying = true;
    }

    if (GUILayout.Button("停止")){
        m_RotateTarget.IsPlaying = false;
    }

    if (GUILayout.Button("リセット")){
        m_RotateTarget.Reset();
    }
  }

}