using UnityEngine;
using System.Collections;
using Unity.PerformanceTesting;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class StaticScene_RenderPerformanceTests : RenderPerformanceTestsBase
{
    private readonly string basicSceneName = "RenderPerformance";
    private readonly string bakedLightingTestSceneName = "BakedLighting";

    protected SampleGroupDefinition[] SamplerNames = {
        new SampleGroupDefinition("Camera.Render"),
        new SampleGroupDefinition("Render.Mesh"),
    };

    [UnityTest, Performance]
    public IEnumerator EmptyScene()
    {
        yield return SceneManager.LoadSceneAsync(basicSceneName, LoadSceneMode.Additive);

        SetActiveScene(basicSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<StaticRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(basicSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator BakedLighting()
    {
        yield return SceneManager.LoadSceneAsync(bakedLightingTestSceneName, LoadSceneMode.Additive);

        SetActiveScene(bakedLightingTestSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<StaticRenderPerformanceMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(bakedLightingTestSceneName);
    }

    [UnityTest, Performance]
    public IEnumerator SinglePrimitiveCube()
    {
        yield return SceneManager.LoadSceneAsync(basicSceneName, LoadSceneMode.Additive);

        SetActiveScene(basicSceneName);

        // Instantiate performance test object in scene
        var renderPerformanceTest = SetupPerfTest<StaticRenderPerformanceWithObjMonoBehaviourTest>();

        // allow time to settle before taking measurements
        yield return new WaitForSecondsRealtime(SettleTimeSeconds);

        // use ProfilerMarkers API from Performance Test Extension
        using (Measure.ProfilerMarkers(SamplerNames))
        {
            // Set CaptureMetrics flag to TRUE; let's start capturing metrics
            renderPerformanceTest.component.CaptureMetrics = true;

            // Run the MonoBehaviour Test
            yield return renderPerformanceTest;
        }

        yield return SceneManager.UnloadSceneAsync(basicSceneName);
    }
}