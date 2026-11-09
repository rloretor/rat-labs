using UnityEditor;
using UnityEditor.Build.Reporting;

public static class WebGLBuild
{
    public static void Build()
    {
        // GitHub Pages can't serve Content-Encoding for .br/.gz, so ship uncompressed (Pages gzips on its own)
        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Disabled;

        PlayerSettings.SplashScreen.show = false;
        PlayerSettings.SplashScreen.showUnityLogo = false;

        var options = new BuildPlayerOptions
        {
            scenes = System.Array.ConvertAll(
                System.Array.FindAll(EditorBuildSettings.scenes, s => s.enabled), s => s.path),
            locationPathName = "build/WebGL",
            target = BuildTarget.WebGL,
        };

        var report = BuildPipeline.BuildPlayer(options);
        if (report.summary.result != BuildResult.Succeeded)
            EditorApplication.Exit(1);
    }
}
