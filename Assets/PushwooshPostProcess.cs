using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEditor.Callbacks;
using System.Collections;
#if UNITY_IOS
using UnityEditor.iOS.Xcode;
#endif
using System.IO;

#if UNITY_EDITOR
public class PushwooshPostProcess : MonoBehaviour{
	[PostProcessBuildAttribute(0)]

	public static void OnPostProcessBuild(BuildTarget buildTarget, string path)
	{
		#if UNITY_IOS
		if (buildTarget == BuildTarget.iOS) {
			string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
						
			PBXProject proj = new PBXProject();

			proj.ReadFromString(File.ReadAllText(projPath));
			
			string target = proj.TargetGuidByName("Unity-iPhone");
			
			// Add custom system frameworks. Duplicate frameworks are ignored.
			// needed by our native plugin in Assets/Plugins/iOS
			proj.AddFrameworkToProject(target, "Security.framework", false /*not weak*/);
			proj.AddBuildProperty (target, "OTHER_LDFLAGS", "-ObjC");

			File.WriteAllText(projPath, proj.WriteToString());
			//Debug.Log(proj.WriteToString());
		}
		#endif
	}
}
#endif